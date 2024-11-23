using System;
using System.Collections.Generic;
using System.Drawing;
using System.Linq;
using System.Threading.Tasks;
using System.Windows.Forms;
using static System.Windows.Forms.VisualStyles.VisualStyleElement.TrackBar;

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

    public class ReplacePixels
    {
        private Dictionary<int, List<Pixel>> storage;
        int index = -1;
        public ReplacePixels()
        {
            storage = new Dictionary<int, List<Pixel>>();
        }

        public void pushPixel(int index, Pixel pixel)
        {
            if (this.index == -1)
            {
                storage.Add(index, new List<Pixel>());
                this.index = index;
            }
            storage[this.index].Add(pixel);
        }

        public void clearCurrentList()
        {
            storage.Remove(index);
        }

        public void resetIndex()
        {
            index = -1;
        }

        public int getCurrentListLength()
        {
            if (index == -1)
            {
                return index;
            }
            else
            {
                return storage[index].Count;
            }
        }

        public Dictionary<int, List<Pixel>> getStorage()
        {
            return storage;
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
        //Размер маски
        private readonly MaskSize maskSize;
        //Предел замены - разница яркостей, при которой мы заменяем значение
        private readonly byte filterLimit;
        //Длина последовательности - минимальная длина последовательности пикселей под замену
        private int sequenceLength;
        // Максимальное число пикселей в маске
        private int MaskPixelsCount;
        // Массив координат маски, пиксели на которых могут обновляться
        private MaskUpdateablePoints updateablePoints;

        ProgressBar progressBar;

        public MedianFilter(Bitmap imgData, byte limit, MaskSize size, int minLineLength)
        {
            imgController = new ImageController(imgData); 
            // FIXME: FilterLimit более не используется
            filterLimit = limit;
            maskSize = size;
            sequenceLength = minLineLength;
            updateablePoints = new MaskUpdateablePoints();
            init();
        }

        private void init()
        {
            MaskPixelsCount = maskSize.width * 2 + maskSize.height - 2;
            maskCoords = getMaskCoords();
            setUpdateablePoints();
        }

        public void setProgressBar(ProgressBar progressBar)
        {
            this.progressBar = progressBar;
            progressBar.Value = 0;
            progressBar.Visible = true;
            progressBar.Maximum = imgController.height;
        }

        private Point[] getMaskCoords()
        {
            MaskSize size = maskSize;
            Point[] maskCoords = new Point[MaskPixelsCount];
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

        private void fillMask(Point currentPos, ref Pixel[] mask)
        {
            Pixel[] newMaskPixels= new Pixel[MaskPixelsCount];
            int index = 0;
            foreach (Point maskPoint in maskCoords)
            {
                if (imgController.IsExistPixel(currentPos.X + maskPoint.X, currentPos.Y + maskPoint.Y))
                {
                    var pixel = imgController.GetPixel(currentPos.X + maskPoint.X, currentPos.Y + maskPoint.Y);
                    newMaskPixels[index]=pixel;
                    index++;
                }
            }
            mask = newMaskPixels.Take(index).ToArray();
        }

        private void updateMask(Point currentPos, ref Pixel[] mask )
        {
            int maskWidth = maskSize.width;
            int maskHeight = maskSize.height;
            int imgWidth = imgController.width;
            int imgHeight = imgController.height;
            int x = currentPos.X;
            int y = currentPos.Y;
            if (x > maskWidth / 2 && y > maskHeight / 2 && x < imgWidth - maskWidth / 2  && y < imgHeight - maskHeight / 2)
            {
                Pixel[] newMaskPixels = new Pixel[MaskPixelsCount];
                // Заполняем верхнюю строку
                Pixel[] topArray = updateTop(currentPos, updateablePoints.top, mask);
                // Заполняем одиночные элементы
                Pixel[] middleArray =  updateMiddle(currentPos);
                // Заполняем нижнюю строку
                Pixel[] bottomArray = updateBottom(currentPos, updateablePoints.bottom, mask);

                Array.Copy(topArray, 0, newMaskPixels, 0, topArray.Length);
                Array.Copy(middleArray, 0, newMaskPixels, topArray.Length, middleArray.Length);
                Array.Copy(bottomArray, 0, newMaskPixels, topArray.Length+middleArray.Length, bottomArray.Length);
                mask = newMaskPixels;
            }
            else
            {
                 fillMask(currentPos, ref mask);
            }
        }

        private Pixel[] updateTop(Point currentPos, Point point, Pixel[] mask)
        {
            Pixel[] arr = new Pixel[maskSize.width];
            Array.Copy(mask, 1, arr, 0, maskSize.width - 1);
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

        private Pixel[] updateBottom(Point currentPos, Point point, Pixel[] mask)
        {
            Pixel[] arr = new Pixel[maskSize.width];
            Array.Copy(mask, mask.Length - maskSize.width + 1, arr, 0, maskSize.width - 1);
            arr[maskSize.width-1] = imgController.GetPixel(currentPos.X + point.X, currentPos.Y + point.Y);
            return arr;
        }

        private void fillRowPixels(Point currentPos, Pixel[] mask, ReplacePixels replacePixels)
        {
            Pixel[] sortedPixels = new Pixel[mask.Length];
            mask.CopyTo(sortedPixels,0);
            Array.Sort(sortedPixels, (a, b) => (b.r + b.g + b.b).CompareTo(a.r + a.g + a.b));
            Pixel medianPixel = sortedPixels[(sortedPixels.Length + 1) / 2 ];
            byte medianBrightness = (byte)(medianPixel.rgbSum / 3);
            byte currentBrightness = (byte)imgController.getPixelMiddleValue(currentPos.X, currentPos.Y);
            if (medianBrightness != currentBrightness)
            {
                replacePixels.pushPixel(currentPos.X, medianPixel);
            }
            else
            {
                if(replacePixels.getCurrentListLength() < sequenceLength)
                {
                   replacePixels.clearCurrentList();
                }
                replacePixels.resetIndex();
            }
        }

        private void filterRow(int rowIndex, ReplacePixels replacePixels)
        {
            foreach (var row in replacePixels.getStorage()) {
                for (int i = 0; i < row.Value.Count; i++)
                {
                    imgController.SetPixel(row.Key+i, rowIndex, row.Value[i]);
                }
            }
            replacePixels = null;
        }

        private void processRow(int y)
        {
            int x = 0;
            ReplacePixels replacePixels = new ReplacePixels();
            Pixel[] rowMask = new Pixel[MaskPixelsCount];
            fillMask(new Point(x,y), ref rowMask);
            while(x < imgController.width - 1)
            {
                fillRowPixels(new Point(x, y), rowMask, replacePixels);
                updateMask(new Point(x,y), ref rowMask );
                x++;
            }
            filterRow(y, replacePixels);
        }

        public void doFiltration()
        {
            // Количество потоков процессора
            int numCores = Environment.ProcessorCount;
            // Создание массива задач
            Task[] taskSet = new Task[numCores];
            // Обработка строк изображения параллельно
            for (int i = 0; i < imgController.height - 1; i++)
            {
                if (i % 100 == 0)
                {
                    progressBar.Value= i;
                }
                // Создание новой задачи, если пул не заполнен
                if (i < numCores)
                {
                    taskSet[i] = Task.Run(() => processRow(i));
                }
                else
                {
                    // Ожидание завершения одной из задач и замена ее новой
                    Task completedTask = Task.WhenAny(taskSet).Result;
                    int completedTaskIndex = Array.IndexOf(taskSet, completedTask);
                    taskSet[completedTaskIndex] = Task.Run(() => processRow(i));
                }
            }
            Task.WaitAll(taskSet);
            imgController.updateImageData();
            progressBar.Visible = false;
        }


        public Bitmap getResultImage()
        {
            return imgController.GetImg();
        }
    }
}
