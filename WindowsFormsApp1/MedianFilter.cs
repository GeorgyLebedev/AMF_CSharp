using System;
using System.Collections.Generic;
using System.Drawing;
using System.Linq;
using System.Threading.Tasks;
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

    public class MaskUpdateablePoints
    {
        public Point top;
        public Point[] middle;
        public Point bottom;
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
        // Массив координат маски, пиксели на которых могут обновляться
        private MaskUpdateablePoints updateablePoints;

        public MedianFilter(Bitmap imgData, byte limit, MaskSize size, int minLineLength)
        {
            imgController = new ImageController(imgData); 
            // FIXME: FilterLimit более не используется
            filterLimit = limit;
            maskSize = size;
            currentPosition = new Point(0, 0);
            sequenceLength = minLineLength;
            updateablePoints = new MaskUpdateablePoints();
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
            updateablePoints.top = new Point(maskSize.width / 2, maskSize.height / 2);
            updateablePoints.bottom = new Point(maskSize.width / 2, -maskSize.height / 2);
            updateablePoints.middle = maskCoords.Where(point=>point.X==0 && Math.Abs(point.Y)!=maskSize.height/2).ToArray();
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
                // Заполняем верхнюю строку
                Pixel[] topArray = updateTop(currentPosition, updateablePoints.top);
                // Заполняем одиночные элементы
                Pixel[] middleArray =  updateMiddle(currentPosition);
                // Заполняем нижнюю строку
                Pixel[] bottomArray = updateBottom(currentPosition, updateablePoints.bottom);

                Array.Copy(topArray, 0, maskPixels, 0, topArray.Length);
                Array.Copy(middleArray, 0, maskPixels, topArray.Length, middleArray.Length);
                Array.Copy(bottomArray, 0, maskPixels, topArray.Length+middleArray.Length, bottomArray.Length);
            }
            else
            {
                fillMask();
            }
        }

        private Pixel[] updateTop(Point currentPos, Point point)
        {
            Pixel[] arr = new Pixel[maskSize.width];
            Array.Copy(maskPixels, 1, arr, 0, maskSize.width - 1);
            arr[maskSize.width - 1] = imgController.GetPixel(currentPos.X + point.X, currentPos.Y + point.Y);
            return arr;
        }
        private Pixel[] updateMiddle(Point currentPos)
        {
            Pixel[] arr = new Pixel[maskSize.height - 2]; 
            for(int j =0; j < updateablePoints.middle.Length; j++)
            {
                arr[j] = imgController.GetPixel(currentPos.X + updateablePoints.middle[j].X, currentPos.Y + updateablePoints.middle[j].Y);
            }
            return arr;
        }

        private Pixel[] updateBottom(Point currentPos, Point point)
        {
            Pixel[] arr = new Pixel[maskSize.width];
            Array.Copy(maskPixels, maskPixels.Length - maskSize.width + 1, arr, 0, maskSize.width - 1);
            arr[maskSize.width-1] = imgController.GetPixel(currentPos.X + point.X, currentPos.Y + point.Y);
            return arr;
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
