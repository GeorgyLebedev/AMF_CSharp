using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace WindowsFormsApp1.entities.medianFilterEnitites
{
    public class SequenceArray
    {
        private Dictionary<int, List<Pixel>> sequences = new Dictionary<int, List<Pixel>>();
        private int index = -1;

        public void pushPixel(int index, Pixel pixel)
        {
            if (this.index == -1)
            {
                sequences.Add(index, new List<Pixel>());
                this.index = index;
            }
            sequences[this.index].Add(pixel);
        }

        public void clearCurrentSequence()
        {
            sequences.Remove(index);
        }

        public void resetIndex()
        {
            index = -1;
        }

        public int getCurrentSequenceLength()
        {
            if (index == -1)
            {
                return index;
            }
            else
            {
                return sequences[index].Count;
            }
        }

        public Dictionary<int, List<Pixel>> getSequences()
        {
            return sequences;
        }

    }

}
