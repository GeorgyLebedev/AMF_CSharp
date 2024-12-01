using System;
using System.Drawing;
using System.Threading.Tasks;

namespace WindowsFormsApp1.entities.medianFilterEnitites
{
    public class FilterAnalyzer : MedianFilter
    {

        public FilterAnalyzer(Bitmap imageData, byte minBrigthness, MaskSize size, int minLineLength):base(imageData, minBrigthness, size, minLineLength)
        {
            imgController = new ImageController(imageData);
            base.minBrigthness = minBrigthness;
            sequenceLength = minLineLength;
            mask = new Mask(size, imgController);
        }

        protected new void filterReplacePixels(int rowIndex, ReplacePixels replacePixels)
        {
            foreach (var list in replacePixels.getStorage())
            {
                for (int i = 0; i < list.Value.Count; i++)
                {
                    imgController.SetPixelColor(list.Key + i, rowIndex, Color.LightCoral);
                }
            }
            replacePixels = null;
        }
        protected new void processRow(int y)
        {
            int x = 0;
            ReplacePixels replacePixels = new ReplacePixels();
            Pixel[] maskPixels = new Pixel[mask.pixelsCount];
            mask.fill(new Point(x, y), ref maskPixels);
            while (x < imgController.width - 1)
            {
                fillReplacePixels(new Point(x, y), maskPixels, replacePixels);
                mask.update(new Point(x, y), ref maskPixels);
                x++;
            }
            filterReplacePixels(y, replacePixels);
        }

        public async Task<Bitmap> doAnalysis()
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
                    progressBar.Value = i;
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
