using System;
using System.Collections.Generic;
using System.Drawing;
using System.Linq;
using System.Windows.Forms;

namespace WindowsFormsApp1
{
    public class MedianFilter
    {
        //Класс для управления пикселями изображения
        private ImageController imgController;
        //Массив локальных координат маски
        private List<Point> maskCoords;
        //Массив пикселей маски
        private List<Pixel> maskPixels;
        //Текущая позиция - координаты текущего пикселя в изображении
        private Point currentPosition;
        //Размер маски
        private readonly byte[] maskSize;
        //Предел замены - разница яркостей, при которой мы заменяем значение
        private readonly byte filterLimit;
        //Длина последовательности - минимальная длина последовательности пикселей под замену
        private int sequenceLength;
        //Словарь массивов пискелей под замену в строке
        private Dictionary<int,List<Pixel>> rowPixels = new Dictionary<int, List<Pixel>>();
        //Массив пикселей под замену в строке
        private List<Pixel> columnPixels = new List<Pixel>();

        public MedianFilter(Bitmap imgData, byte limit, byte[] size, int minLineLength)
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
            maskCoords = createMask(maskSize);
            updateMask();
        }

        private List<Point> createMask(byte[] size)
        {
            List<Point> maskCoords = new List<Point>();
            Point centerPoint = new Point(size[0]/2, size[1]/2); 
            for (int x = 0; x < size[0]; x++)
            {
                for(int y = 0; y < size[1]; y++)
                {
                    if(y == 0 || y == size[0] - 1 || x == centerPoint.X)
                    {
                        //Заполняем все точки в первой строке или стоблце, а таже центральные
                        Point maskPoint = new Point(x - centerPoint.X, y - centerPoint.Y);
                        maskCoords.Add(maskPoint);
                       // Console.WriteLine(maskPoint);
                    }
                }
            }
            return maskCoords;
        }

        private void updateMask()
        {
            maskPixels = new List<Pixel>();
            foreach (Point maskPoint in maskCoords)
            {
                if (imgController.IsExistPixel(currentPosition.X + maskPoint.X, currentPosition.Y + maskPoint.Y))
                {
                    var pixel = imgController.GetPixel(currentPosition.X + maskPoint.X, currentPosition.Y + maskPoint.Y);
                    maskPixels.Add(pixel);
                }
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
            maskPixels.Sort((a, b) => (b.r + b.g + b.b).CompareTo(a.r + a.g + a.b));
            Pixel median = maskPixels[(maskPixels.Count - 1) / 2];
            byte medianBrightness = Convert.ToByte((median.r + median.g + median.b) / 3);
            Pixel currentPixel = imgController.GetPixel(currentPosition.X, currentPosition.Y);
            byte currentBrightness = Convert.ToByte((currentPixel.r + currentPixel.g + currentPixel.b) / 3);
            if (Math.Abs(medianBrightness - currentBrightness) >= filterLimit)
            {
                columnPixels.Add(median);
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
