using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace WindowsFormsApp1.entities.medianFilterEnitites
{
    public class FilterOptions
    {
        //Номинальное значение яркости линий, при котором линия будет фильтроваться
        public readonly int minBrightness;
        //Длина последовательности - минимальная длина последовательности пикселей под замену
        public readonly int sequenceLength;
        // Использовать потоки процессора
        public readonly bool useMultiThread;

        public FilterOptions(int minBrightness, int sequenceLength, bool useMultiThread)
        {
            this.minBrightness = minBrightness;
            this.sequenceLength = sequenceLength;
            this.useMultiThread = useMultiThread;
        }
    }
}
