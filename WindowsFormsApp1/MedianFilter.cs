using System;
using System.Drawing;
using System.Threading.Tasks;
using System.Windows.Forms;
using WindowsFormsApp1.types;

namespace WindowsFormsApp1
{
    public class MedianFilter
    {
        //Класс для управления пикселями изображения
        private ImageController imgController;
        //Номинальное значение яркости линий, при котором линия будет фильтроваться
        private readonly byte minBrigthness;
        //Длина последовательности - минимальная длина последовательности пикселей под замену
        private int sequenceLength;
        //Маска фильтра
        private Mask mask;

        Guna.UI2.WinForms.Guna2CircleProgressBar progressBar;

        public MedianFilter(Bitmap imageData, byte minBrigthness, MaskSize size, int minLineLength)
        {
            imgController = new ImageController(imageData); 
            this.minBrigthness = minBrigthness;
            sequenceLength = minLineLength;
            mask = new Mask(size, imgController);
        }

        public void setProgressBar(Guna.UI2.WinForms.Guna2CircleProgressBar progressBar)
        {
            this.progressBar = progressBar;
            progressBar.Value = 0;
            progressBar.Visible = true;
            progressBar.Maximum = imgController.height;
        }

        private void fillReplacePixels(Point currentPos, Pixel[] mask, ReplacePixels replacePixels)
        {
            Pixel[] sortedPixels = new Pixel[mask.Length];
            mask.CopyTo(sortedPixels,0);
            Array.Sort(sortedPixels, (a, b) => (b.r + b.g + b.b).CompareTo(a.r + a.g + a.b));
            Pixel medianPixel = sortedPixels[(sortedPixels.Length + 1) / 2 ];
            byte medianBrightness = (byte)(medianPixel.rgbSum / 3);
            byte currentBrightness = (byte)imgController.getPixelMiddleValue(currentPos.X, currentPos.Y);
            if (medianBrightness != currentBrightness && currentBrightness>minBrigthness)
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

        private void filterReplacePixels(int rowIndex, ReplacePixels replacePixels)
        {
            foreach (var list in replacePixels.getStorage()) {
                for (int i = 0; i < list.Value.Count; i++)
                {
                    imgController.SetPixel(list.Key+i, rowIndex, list.Value[i]);
                }
            }
            replacePixels = null;
        }

        private void processRow(int y)
        {
            int x = 0;
            ReplacePixels replacePixels = new ReplacePixels();
            Pixel[] maskPixels = new Pixel[mask.pixelsCount];
            mask.fill(new Point(x,y), ref maskPixels);
            while(x < imgController.width - 1)
            {
                fillReplacePixels(new Point(x, y), maskPixels, replacePixels);
                mask.update(new Point(x,y), ref maskPixels);
                x++;
            }
            filterReplacePixels(y, replacePixels);
        }

        public async Task<Bitmap> doFiltration()
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
                    var completedTask = await Task.WhenAny(taskSet);
                    int completedTaskIndex = Array.IndexOf(taskSet, completedTask);
                    taskSet[completedTaskIndex] = Task.Run(() => processRow(i));
                }
            }
            progressBar.Visible = false;
            return imgController.updateImageData();
        }
    }
}
