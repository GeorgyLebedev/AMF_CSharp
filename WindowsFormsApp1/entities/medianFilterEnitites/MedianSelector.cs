using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace WindowsFormsApp1.entities.medianFilterEnitites
{
    public class MedianSelector
    {
        // Метод быстрого выбора для нахождения медианы
        public Pixel quickSelect(Pixel[] array)
        {
            int medianIndex = (array.Length - 1) / 2;
            int left = 0;
            int right = array.Length - 1;

            while (left < right)
            {
                int targetIndex = partition(array, left, right);
                if (targetIndex == medianIndex)
                    return array[medianIndex];
                else if (targetIndex < medianIndex)
                    left = targetIndex + 1;
                else
                    right = targetIndex - 1;
            }
            return array[medianIndex];
        }

        // Метод разбиения для быстрого выбора
        private int partition(Pixel[] array, int left, int right)
        {
            int target = array[left].r + array[left].g + array[left].b;
            int i = left;
            int j = right + 1;

            while (true)
            {
                while (i < right && (array[++i].r + array[i].g + array[i].b) > target);
                while (j > left && (array[--j].r + array[j].g + array[j].b) < target);
                if (i >= j)
                    break;
                swap(array, i, j);
            }
            swap(array, left, j);
            return j;
        }

        // Метод обмена элементов массива
        private void swap(Pixel[] array, int i, int j)
        {
            Pixel temp = array[i];
            array[i] = array[j];
            array[j] = temp;
        }
    }
}
