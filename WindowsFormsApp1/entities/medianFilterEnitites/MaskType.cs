
using System;
using System.Drawing;
using System.Linq;

namespace WindowsFormsApp1.entities.medianFilterEnitites
{

    public enum MaskTypeEnum
    {
        TypeA = 0,
        TypeB = 1,
        TypeC = 2
    }

    public class MaskType
    {
        private int[] dynamicIndexes;
        private int[] staticIndexes;
        private MaskTypeEnum maskType;
        private Point[] coordinates;
        private Point centerPoint;
        private int pixelsCount;
        private Size maskSize;

        public MaskType(Size maskSize, MaskTypeEnum maskType)
        {
            this.maskType = maskType;
            updateSize(maskSize);
        }


        private void setConfig()
        {
            switch (maskType)
            {
                case MaskTypeEnum.TypeA:
                    setConfigA();
                    break;
                case MaskTypeEnum.TypeB:
                    setConfigB();
                    break;
                case MaskTypeEnum.TypeC:
                    setConfigC();
                    break;

            }
        }

        private void setConfigA()
        {
            pixelsCount = maskSize.Width * 2 + maskSize.Height - 2;

            dynamicIndexes = new int[maskSize.Height];
            dynamicIndexes = Enumerable.Range(maskSize.Width - 1, maskSize.Height - 2).ToArray();
            dynamicIndexes[dynamicIndexes.Length - 1] = pixelsCount - 1;
            fillStaticIndexes();

            coordinates = new Point[pixelsCount];
            int coordIndex = 0;
            for (int y = 0; y < maskSize.Height; y++)
            {
                for (int x = 0; x < maskSize.Width; x++)
                {
                    if (y == 0 || y == maskSize.Height - 1 || x == centerPoint.X)
                    {
                        //Заполняем все точки в первой и последней строке, а также центральные
                        Point maskPoint = new Point(x - centerPoint.X, y - centerPoint.Y);
                        coordinates[coordIndex] = maskPoint;
                        coordIndex++;
                    }
                }
            }
        }

        private void setConfigB()
        {
            pixelsCount = maskSize.Width * 4 + maskSize.Height - 4;

            dynamicIndexes = new int[maskSize.Height];
            dynamicIndexes[0] = maskSize.Width - 1;
            var range = Enumerable.Range((maskSize.Width - 1) * 2, maskSize.Height - 4).ToArray();
            Array.Copy(range, 0, dynamicIndexes, 1, range.Length);
            dynamicIndexes[maskSize.Height - 2] = pixelsCount - maskSize.Width - 1;
            dynamicIndexes[maskSize.Height - 1] = pixelsCount - 1;
            fillStaticIndexes();

            coordinates = new Point[pixelsCount];
            int coordIndex = 0;
            int[] edges = new int[] { 0, 1, maskSize.Height - 1, maskSize.Height - 2 };
            for (int y = 0; y < maskSize.Height; y++)
            {
                for (int x = 0; x < maskSize.Height; x++)
                {
                    if (edges.Contains(y) || x == centerPoint.X)
                    {
                        //Заполняем все точки в первой и последней строке, а также центральные
                        Point maskPoint = new Point(x - centerPoint.X, y - centerPoint.Y);
                        coordinates[coordIndex] = maskPoint;
                        coordIndex++;
                    }
                }
            }
        }

        private void setConfigC()
        {
            pixelsCount = maskSize.Width * 2 + 1;

            dynamicIndexes = new int[] { maskSize.Width-1, maskSize.Width, pixelsCount-1 };
            fillStaticIndexes();

            coordinates = new Point[pixelsCount];
            int index = 0;
            for (int y = 0; y < maskSize.Height; y++)
            {
                for (int x = 0; x < maskSize.Width; x++)
                {

                    if (y == 0 || y == maskSize.Height - 1 || (x == centerPoint.X && y == centerPoint.Y))
                    {
                        //Заполняем все точки в первой строке и последней строке, а также одну центральную
                        Point maskPoint = new Point(x - centerPoint.X, y - centerPoint.Y);
                        coordinates[index] = maskPoint;
                        index++;
                    }
                }
            }
        }

        private void fillStaticIndexes()
        {
            staticIndexes = Enumerable.Range(0, pixelsCount).Except(dynamicIndexes).ToArray();
        }

        public void updateSize(Size newSize)
        {
            maskSize = newSize;
            centerPoint = new Point(maskSize.Width / 2, maskSize.Height / 2);
            setConfig();
        }

        public void updateType(MaskTypeEnum newType)
        {
            maskType = newType;
            setConfig();
        }

        public Size getSize()
        {
            return maskSize;
        }

        public int getPixelsCount()
        {
            return pixelsCount;
        }

        public Point[] getCoordinates()
        {
            return coordinates;
        }

        public int[] getStaticIndexes()
        {
            return staticIndexes;
        }

        public int[] getDynamicUndexes()
        {
            return dynamicIndexes;
        }

    }
}
