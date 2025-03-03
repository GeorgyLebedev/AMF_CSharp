using System;
using System.Drawing;
using System.Threading.Tasks;
using WindowsFormsApp1.entities;

namespace WindowsFormsApp1.entities.medianFilterEnitites
{
    public class MedianFilter
    {
        //Класс для управления пикселями изображения
        private ImageController imageController;
        //Маска фильтра
        private Mask mask;
        //Опции фильтрации
        private FilterOptions options;
        //Селектор для поиска медианы
        private MedianSelector selector = new MedianSelector();

        Guna.UI2.WinForms.Guna2CircleProgressBar progressBar;

        public MedianFilter(FilterOptions options, Bitmap imageData, MaskType maskType)
        {
            imageController = new ImageController(imageData); 
            this.options = options;
            mask = new Mask(maskType, imageController);
        }

        public void setProgressBar(Guna.UI2.WinForms.Guna2CircleProgressBar progressBar)
        {
            this.progressBar = progressBar;
            progressBar.Value = 0;
            progressBar.Visible = true;
            progressBar.Maximum = imageController.height;
        }

        private void fillSequences(Point currentPos, Pixel[] mask, SequenceArray sequences)
        {
            // Копируем пиксели из маски в новый массив
            Pixel[] pixelsCopy = new Pixel[mask.Length];
            mask.CopyTo(pixelsCopy, 0);

            Pixel medianPixel = selector.quickSelect(pixelsCopy);

            // Получаем текущую яркость пикселей
            byte medianBrightness = (byte)(medianPixel.rgbSum);
            byte currentBrightness = (byte)imageController.getPixel(currentPos.X, currentPos.Y).rgbSum;
            byte diff = (byte)(Math.Abs(currentBrightness - medianBrightness));
            // Сравниваем яркости и заменяем пиксель при необходимости
            if (diff >= options.minimalBrightness)
            {
                sequences.pushPixel(currentPos.X, medianPixel);
            }
            else
            {
                if (sequences.getCurrentSequenceLength() < options.sequenceLength)
                {
                    sequences.clearCurrentSequence();
                }
                sequences.resetIndex();
            }
        }

        private void filterSequences(int rowIndex, SequenceArray sequences)
        {
            foreach (var sequence in sequences.getSequences())
            {
                for (int i = 0; i < sequence.Value.Count; i++)
                {
                    imageController.setPixel(sequence.Key + i, rowIndex, sequence.Value[i]);
                    //imageController.setPixel(sequence.Key + i, rowIndex, Color.Maroon);
                }
            }
            sequences = null;
        }

        private void processRow(int y)
        {
            int x = 0;
            SequenceArray sequences = new SequenceArray();
            Pixel[] maskPixels = mask.fill(new Point(x,y));
            while(x < imageController.width - 1)
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
            for (int i = 0; i < imageController.height - 1; i++)
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
            return imageController.updateImageData();
        }
    }
}
