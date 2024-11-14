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
        private int [] updateableIndexes;

        public MedianFilter(Bitmap imgData, byte limit, MaskSize size, int minLineLength)
        {
            imgController = new ImageController(imgData);  
            filterLimit = limit;
            maskSize = size;
            currentPosition = new Point(0, 0);
            sequenceLength = minLineLength;
            init();
        }

        private void init()
        {
            MaskArrayLength = maskSize.width * 2 + maskSize.height - 2;
            maskCoords = createMask(maskSize);
            fillMask();
        }


        private Point[] createMask(MaskSize size)
        {
            Point[] maskCoords = new Point[MaskArrayLength];
            updateableIndexes = new int[size.height];
            Point centerPoint = new Point(size.width/2, size.height/2);
            int coordIndex = 0;
            int index = 0;
            for (int x = 0; x < size.width; x++)
            {
                for(int y = 0; y < size.height; y++)
                {
                    if ((x == centerPoint.X && y > 0 && y < size.height - 1) || (x == size.width - 1 && (y==0 || y==size.height-1)))
                    {
                        updateableIndexes[index] = coordIndex;
                        index++;
                    }
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
            if (currentPosition.X > maskSize.width / 2 && currentPosition.Y > maskSize.height / 2 && currentPosition.X < imgController.width - maskSize.width / 2  && currentPosition.Y < imgController.height - maskSize.height / 2)
            {
                Pixel[] tempArray = new Pixel[MaskArrayLength];
                Array.Copy(maskPixels, 1, tempArray, 0, maskSize.width - 1);
                Array.Copy(maskPixels, maskPixels.Length - maskSize.width-1, tempArray, maskSize.width-1, maskSize.width-1);
                int i = 2*(maskSize.width - 1);
                foreach (int index in updateableIndexes)
                {
                    tempArray[i] = imgController.GetPixel(currentPosition.X + maskCoords[index].X, currentPosition.Y + maskCoords[index].Y);
                    i++;
                }
                maskPixels = tempArray;
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
            //insertionSort(maskPixels);
            Pixel medianPixel = sortedPixels[sortedPixels.Length / 2];
            byte medianBrightness = (byte)(medianPixel.rgbSum / 3);
            byte currentBrightness = (byte)imgController.getPixelMiddleValue(currentPosition.X, currentPosition.Y);
            if (Math.Abs(medianBrightness - currentBrightness) >= filterLimit)
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

/*        private void insertionSort(Pixel[] array)
        {
            for (int i = 1; i < array.Length; i++)
            {
                Pixel current = array[i];
                int j = i - 1;
                while (j >= 0 && array[j].rgbSum > current.rgbSum)
                {
                    array[j + 1] = array[j];
                    j--;
                }
                array[j + 1] = current;
            }
        }
*/
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
