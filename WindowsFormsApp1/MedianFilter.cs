using System;
using System.Collections.Generic;
using System.Drawing;
using System.Linq;
using System.Windows.Forms;

namespace WindowsFormsApp1
{
    public class MaskSize
    {
        public readonly byte width;
        public readonly byte height; 

        public MaskSize(byte width, byte height) { 
            this.width = width; 
            this.height = height;
        }

    }

    public class MedianFilter
    {
        //Класс для управления пикселями изображения
        private ImageController imgController;
        //Массив локальных координат маски
        private Point[] maskCoords;
        //Массив пикселей маски
        private Pixel[] maskPixels;
        //Текущая позиция - координаты текущего пикселя в изображении
        private Point currentPosition;
        //Размер маски
        private readonly MaskSize maskSize;
        //Предел замены - разница яркостей, при которой мы заменяем значение
        private readonly byte filterLimit;
        //Длина последовательности - минимальная длина последовательности пикселей под замену
        private int sequenceLength;
        //Словарь массивов пискелей под замену в строке
        private Dictionary<int,List<Pixel>> rowPixels = new Dictionary<int, List<Pixel>>();
        //Массив пикселей под замену в строке
        private List<Pixel> columnPixels = new List<Pixel>();
        // Длина массивов, связанных с маской
        private int MaskArrayLength;
        // Массив индексов пикселей маски, которые могут обновляться
        private Point [] updateablePoints;

        public MedianFilter(Bitmap imgData, byte limit, MaskSize size, int minLineLength)
        {
            imgController = new ImageController(imgData); 
            // FIXME: FilterLimit более не используется
            filterLimit = limit;
            maskSize = size;
            currentPosition = new Point(0, 0);
            sequenceLength = minLineLength;
            init();
        }

        private void init()
        {
            MaskArrayLength = maskSize.width * 2 + maskSize.height - 2;
            maskCoords = createMask();
            fillMask();
            setUpdateablePoints();
        }


        private Point[] createMask()
        {
            MaskSize size = maskSize;
            Point[] maskCoords = new Point[MaskArrayLength];
            Point centerPoint = new Point(size.width/2, size.height/2);
            int coordIndex = 0;
            for (int y = 0; y < size.height; y++)
            {
                for (int x = 0; x < size.width; x++)
                {
         
                    if (y == 0 || y == size.width - 1 || x == centerPoint.X)
                    {
                        //Заполняем все точки в первой строке или стоблце, а таже центральные
                        Point maskPoint = new Point(x - centerPoint.X, y - centerPoint.Y);
                        maskCoords[coordIndex]=maskPoint;
                        coordIndex++;
                       // Console.WriteLine(maskPoint);
                    }
                }
            }
            return maskCoords;
        }

        private void setUpdateablePoints()
        {
            updateablePoints = maskCoords.Where(point=>point.X==maskSize.width/2 || point.X==0 && Math.Abs(point.Y)!=maskSize.height/2).ToArray();
        }

        private void fillMask()
        {
            maskPixels = new Pixel[MaskArrayLength];
            int index = 0;
            foreach (Point maskPoint in maskCoords)
            {
                if (imgController.IsExistPixel(currentPosition.X + maskPoint.X, currentPosition.Y + maskPoint.Y))
                {
                    var pixel = imgController.GetPixel(currentPosition.X + maskPoint.X, currentPosition.Y + maskPoint.Y);
                    maskPixels[index]=pixel;
                    index++;
                }
            }
            maskPixels = maskPixels.Take(index).ToArray();
        }

        private void updateMask()
        {
            int x = currentPosition.X;
            int y = currentPosition.Y;
            int maskWidth = maskSize.width;
            int maskHeight = maskSize.height;
            int imgWidth = imgController.width;
            int imgHeight = imgController.height;
            if (x > maskWidth / 2 && y > maskHeight / 2 && x < imgWidth - maskWidth / 2  && y < imgHeight - maskHeight / 2)
            {
                Pixel[] tempArray = new Pixel[MaskArrayLength];
                Point topRight = updateablePoints[0];
                Point bottomRight = updateablePoints[updateablePoints.Length - 1];
                
                // Заполняем верхнюю строку
                Array.Copy(maskPixels, 1, tempArray, 0, maskWidth - 1);
                tempArray[maskWidth - 1] = imgController.GetPixel(x + topRight.X, y + topRight.Y);

                // Заполняем одиночные элементы
                int i = maskWidth;
                for(int index =1; index < updateablePoints.Length-1; index++)
                {
                    tempArray[i] = imgController.GetPixel(x + updateablePoints[index].X, y + updateablePoints[index].Y);
                    i++;
                }

                // Заполняем нижнюю строку
                Array.Copy(maskPixels, maskPixels.Length - maskWidth + 1, tempArray, i, maskWidth - 1);
                tempArray[MaskArrayLength-1] = imgController.GetPixel(x + bottomRight.X, y + bottomRight.Y);

                tempArray.CopyTo(maskPixels, 0);
            }
            else
            {
                fillMask();
            }
        }

        private void moveFilter()
        {
            if(currentPosition.X < imgController.width)
            {
                currentPosition.X++;
            } 
            else
            {
                filterRow();
                currentPosition.X = 0;
                currentPosition.Y++;
            }
        }
    
        private void fillRowPixels()
        {
            Pixel[] sortedPixels = new Pixel[maskPixels.Length];
            maskPixels.CopyTo(sortedPixels,0);
            Array.Sort(sortedPixels, (a, b) => (b.r + b.g + b.b).CompareTo(a.r + a.g + a.b));
            Pixel medianPixel = sortedPixels[(sortedPixels.Length + 1) / 2 ];
            byte medianBrightness = (byte)(medianPixel.rgbSum / 3);
            byte currentBrightness = (byte)imgController.getPixelMiddleValue(currentPosition.X, currentPosition.Y);
            if (medianBrightness != currentBrightness)
            {
                columnPixels.Add(medianPixel);
            }
            else
            {
                if(columnPixels.Count >= sequenceLength)
                {
                    rowPixels.Add(currentPosition.X-columnPixels.Count,columnPixels.ToList());
                }
                columnPixels.Clear();
            }
        }

        private void filterRow()
        {
            foreach (var row in rowPixels) {
                for (int i = 0; i < row.Value.Count; i++)
                {
                    imgController.SetPixel(row.Key+i, currentPosition.Y, row.Value[i]);
                }
            }
            rowPixels.Clear();
        }

        public void doFiltration(ProgressBar progressBar)
        {
            progressBar.Value = 0;
            progressBar.Visible = true;
            progressBar.Maximum = imgController.height;
            while (currentPosition.X < imgController.width-1 || currentPosition.Y < imgController.height-1)
            {
                fillRowPixels();
                moveFilter();
                updateProgessBar(progressBar);
                updateMask();
            }
            imgController.updateImageData();
            progressBar.Visible = false;
        }

        public void updateProgessBar(ProgressBar progressBar)
        {
            if (currentPosition.Y % 20 == 0)
            {
                progressBar.Value = currentPosition.Y;
            }
        }

        public Bitmap getResultImage()
        {
            return imgController.GetImg();
        }
    }
}
