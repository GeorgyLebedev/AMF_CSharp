using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace WindowsFormsApp1.entities.medianFilterEnitites
{
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

}
