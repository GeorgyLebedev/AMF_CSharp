
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
        private int[] updateableIndexes;
        private MaskTypeEnum maskType;
        private Point[] coordinates;
        private Point centerPoint;
        private int pixelsCount;
        public readonly MaskSize maskSize;

        public MaskType(MaskSize maskSize, MaskTypeEnum maskType)
        {
            this.maskSize = maskSize;
            this.maskType = maskType;
            centerPoint = new Point(maskSize.width / 2, maskSize.height / 2);
            setConfig();
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
            pixelsCount = maskSize.width * 2 + maskSize.height - 2;

            updateableIndexes = new int[maskSize.height];
            updateableIndexes = Enumerable.Range(maskSize.width - 1, maskSize.height - 2).ToArray();
            updateableIndexes[updateableIndexes.Length - 1] = pixelsCount - 1;

            coordinates = new Point[pixelsCount];
            int coordIndex = 0;
            for (int y = 0; y < maskSize.height; y++)
            {
                for (int x = 0; x < maskSize.width; x++)
                {
                    if (y == 0 || y == maskSize.height - 1 || x == centerPoint.X)
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
            pixelsCount = maskSize.width * 4 + maskSize.height - 4;

            updateableIndexes = new int[maskSize.height];
            updateableIndexes[0] = maskSize.width - 1;
            var range = Enumerable.Range((maskSize.width - 1) * 2, maskSize.height - 4).ToArray();
            Array.Copy(range, 0, updateableIndexes, 1, range.Length);
            updateableIndexes[maskSize.height - 2] = pixelsCount - maskSize.width - 1;
            updateableIndexes[maskSize.height - 1] = pixelsCount - 1;

            coordinates = new Point[pixelsCount];
            int coordIndex = 0;
            int[] edges = new int[] { 0, 1, maskSize.height - 1, maskSize.height - 2 };
            for (int y = 0; y < maskSize.height; y++)
            {
                for (int x = 0; x < maskSize.width; x++)
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
            pixelsCount = maskSize.width * 2 + 1;

            updateableIndexes = new int[] { maskSize.width-1, maskSize.width, pixelsCount-1 };

            coordinates = new Point[pixelsCount];
            int coordIndex = 0;
            for (int y = 0; y < maskSize.height; y++)
            {
                for (int x = 0; x < maskSize.width; x++)
                {

                    if (y == 0 || y == maskSize.height - 1 || (x == centerPoint.X && y == centerPoint.Y))
                    {
                        //Заполняем все точки в первой строке и последней строке, а также одну центральную
                        Point maskPoint = new Point(x - centerPoint.X, y - centerPoint.Y);
                        coordinates[coordIndex] = maskPoint;
                        coordIndex++;
                    }
                }
            }
        }

        public int getPixelsCount()
        {
            return pixelsCount;
        }

        public Point[] getCoordinates()
        {
            return coordinates;
        }

        public Point getCoordinate(int index)
        {
            return coordinates[index];
        }

        public bool isUpdateableIndex(int index)
        {
            return updateableIndexes.Contains(index);
        }
    }


}
