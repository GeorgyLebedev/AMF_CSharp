using System;
using System.Collections.Generic;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace WindowsFormsApp1.entities
{
    public class QualityEvaluator
    {
        ImageController sourceController;
        ImageController resultController;
        public QualityEvaluator(Bitmap img1, Bitmap img2) {
            sourceController = new ImageController(img1);
            resultController = new ImageController(img2);
        }
        public double evaluate()
        {
            // Динамический диапазон для 8-битных изображений
            const int L = 255;
            double C1 = Math.Pow(0.01 * L, 2);
            double C2 = Math.Pow(0.03 * L, 2);

            double totalSSIM = 0;
            int windowSize = 8;
            int blockCount = 0;

            // Блоки 8x8
            for (int y = 0; y < sourceController.height; y += windowSize)
            {
                for (int x = 0; x < sourceController.width; x += windowSize)
                {
                    // Пропуск неполных блоков
                    if (x + windowSize > sourceController.width || y + windowSize > sourceController.height)
                        continue;

                    double mu1 = 0, mu2 = 0;
                    double sigma1Sq = 0, sigma2Sq = 0, sigma12 = 0;

                    // Расчет средних значений
                    for (int i = y; i < y + windowSize; i++)
                    {
                        for (int j = x; j < x + windowSize; j++)
                        {
                            mu1 += sourceController.getPixelMiddleValue(j,i);
                            mu2 += resultController.getPixelMiddleValue(j, i);
                        }
                    }
                    mu1 /= (windowSize * windowSize);
                    mu2 /= (windowSize * windowSize);

                    // Расчет дисперсий и ковариации
                    for (int i = y; i < y + windowSize; i++)
                    {
                        for (int j = x; j < x + windowSize; j++)
                        {
                            double val1 = sourceController.getPixelMiddleValue(j, i);
                            double val2 = resultController.getPixelMiddleValue(j, i);

                            sigma1Sq += Math.Pow(val1 - mu1, 2);
                            sigma2Sq += Math.Pow(val2 - mu2, 2);
                            sigma12 += (val1 - mu1) * (val2 - mu2);
                        }
                    }
                    sigma1Sq /= (windowSize * windowSize - 1);
                    sigma2Sq /= (windowSize * windowSize - 1);
                    sigma12 /= (windowSize * windowSize - 1);

                    // Расчет SSIM для блока
                    double numerator = (2 * mu1 * mu2 + C1) * (2 * sigma12 + C2);
                    double denominator = (mu1 * mu1 + mu2 * mu2 + C1) * (sigma1Sq + sigma2Sq + C2);
                    totalSSIM += numerator / denominator;
                    blockCount++;
                }
            }

            return totalSSIM / blockCount; // Среднее значение по всем блокам
        }
    }
}
