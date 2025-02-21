using System;
using System.Drawing;
using System.Threading.Tasks;
using WindowsFormsApp1.entities;

namespace WindowsFormsApp1.entities.medianFilterEnitites
{
    public class MedianFilter
    {
        //Класс для управления пикселями изображения
        private ImageController imgController;
        //Маска фильтра
        private Mask mask;
        //Опции фильтрации
        private FilterOptions options;
        private int pixelsCount;

        Guna.UI2.WinForms.Guna2CircleProgressBar progressBar;

        public MedianFilter(FilterOptions options, Bitmap imageData, MaskType maskType)
        {
            imgController = new ImageController(imageData); 
            this.options = options;
            mask = new Mask(maskType, imgController);
            pixelsCount = maskType.getPixelsCount();
        }

        public void setProgressBar(Guna.UI2.WinForms.Guna2CircleProgressBar progressBar)
        {
            this.progressBar = progressBar;
            progressBar.Value = 0;
            progressBar.Visible = true;
            progressBar.Maximum = imgController.height;
        }

        private void fillSequences(Point currentPos, Pixel[] mask, SequenceArray sequences)
        {
            Pixel[] sortedPixels = new Pixel[mask.Length];
            mask.CopyTo(sortedPixels,0);
            Array.Sort(sortedPixels, (a, b) => (b.r + b.g + b.b).CompareTo(a.r + a.g + a.b));
            Pixel medianPixel = sortedPixels[(sortedPixels.Length + 1) / 2 ];
            byte medianBrightness = (byte)(medianPixel.rgbSum / 3);
            byte currentBrightness = (byte)imgController.getPixelMiddleValue(currentPos.X, currentPos.Y);
            if (medianBrightness != currentBrightness && currentBrightness>options.minBrightness)
            {
                sequences.pushPixel(currentPos.X, medianPixel);
            }
            else
            {
                if(sequences.getCurrentSequenceLength() < options.sequenceLength)
                {
                   sequences.clearCurrentSequence();
                }
                sequences.resetIndex();
            }
        }

        private void filterSequences(int rowIndex, SequenceArray sequences)
        {
            foreach (var sequence in sequences.getSequences()) {
                for (int i = 0; i < sequence.Value.Count; i++)
                {
                    imgController.setPixel(sequence.Key+i, rowIndex, sequence.Value[i]);
                }
            }
            sequences = null;
        }

        private void processRow(int y)
        {
            int x = 0;
            SequenceArray sequences = new SequenceArray();
            Pixel[] maskPixels = new Pixel[pixelsCount];
            mask.fill(new Point(x,y), ref maskPixels);
            while(x < imgController.width - 1)
            {
                fillSequences(new Point(x, y), maskPixels, sequences);
                mask.update(new Point(x,y), ref maskPixels);
                x++;
            }
            filterSequences(y, sequences);
        }

        public async Task<Bitmap> doFiltration()
        {
            // Количество потоков процессора
            int numCores = options.useMultiThread ? Environment.ProcessorCount : 1;
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
