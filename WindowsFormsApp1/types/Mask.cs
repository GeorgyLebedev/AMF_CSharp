using System;
using System.Drawing;
using System.Linq;

namespace WindowsFormsApp1.types
{
    public class MaskSize
    {
        public readonly byte width;
        public readonly byte height;

        public MaskSize(byte width, byte height)
        {
            this.width = width;
            this.height = height;
        }

    }

    public class MaskUpdateablePoints
    {
        public Point top;
        public Point[] middle;
        public Point bottom;
    }


    public class Mask
    {
        public Mask(MaskSize maskSize, ImageController imageController)
        {
            size = maskSize;
            this.imageController = imageController;
            setCoordinates();
            setUpdateablePoints();
        }
        private Point[] coordinates;
        private MaskUpdateablePoints updateablePoints;
        private ImageController imageController;
        public readonly MaskSize size;

        public int pixelsCount
        {
            get
            {
                return size.width * 2 + size.height - 2;
            }
        }

        private void setCoordinates()
        {
            coordinates = new Point[pixelsCount];
            Point centerPoint = new Point(size.width / 2, size.height / 2);
            int coordIndex = 0;
            for (int y = 0; y < size.height; y++)
            {
                for (int x = 0; x < size.width; x++)
                {

                    if (y == 0 || y == size.width - 1 || x == centerPoint.X)
                    {
                        //Заполняем все точки в первой строке или стоблце, а таже центральные
                        Point maskPoint = new Point(x - centerPoint.X, y - centerPoint.Y);
                        coordinates[coordIndex] = maskPoint;
                        coordIndex++;
                    }
                }
            }
        }

        private void setUpdateablePoints()
        {
            updateablePoints = new MaskUpdateablePoints();
            updateablePoints.top = new Point(size.width / 2, size.height / 2);
            updateablePoints.bottom = new Point(size.width / 2, -size.height / 2);
            updateablePoints.middle = coordinates.Where(point => point.X == 0 && Math.Abs(point.Y) != size.height / 2).ToArray();
        }

        public void fill(Point currentPos, ref Pixel[] pixels)
        {
            Pixel[] newMaskPixels = new Pixel[pixelsCount];
            int index = 0;
            foreach (Point maskPoint in coordinates)
            {
                if (imageController.IsExistPixel(currentPos.X + maskPoint.X, currentPos.Y + maskPoint.Y))
                {
                    var pixel = imageController.GetPixel(currentPos.X + maskPoint.X, currentPos.Y + maskPoint.Y);
                    newMaskPixels[index] = pixel;
                    index++;
                }
            }
            pixels = newMaskPixels.Take(index).ToArray();
        }
        public void update(Point currentPos, ref Pixel[] pixels)
        {
            int maskWidth = size.width;
            int maskHeight = size.height;
            int imgWidth = imageController.width;
            int imgHeight = imageController.height;
            int x = currentPos.X;
            int y = currentPos.Y;
            if (x > maskWidth / 2 && y > maskHeight / 2 && x < imgWidth - maskWidth / 2 && y < imgHeight - maskHeight / 2)
            {
                Pixel[] newMaskPixels = new Pixel[pixelsCount];
                // Заполняем верхнюю строку
                Pixel[] topArray = updateTop(currentPos, updateablePoints.top, pixels);
                // Заполняем одиночные элементы
                Pixel[] middleArray = updateMiddle(currentPos);
                // Заполняем нижнюю строку
                Pixel[] bottomArray = updateBottom(currentPos, updateablePoints.bottom, pixels);

                Array.Copy(topArray, 0, newMaskPixels, 0, topArray.Length);
                Array.Copy(middleArray, 0, newMaskPixels, topArray.Length, middleArray.Length);
                Array.Copy(bottomArray, 0, newMaskPixels, topArray.Length + middleArray.Length, bottomArray.Length);
                pixels = newMaskPixels;
            }
            else
            {
                fill(currentPos, ref pixels);
            }
        }


        private Pixel[] updateTop(Point currentPos, Point point, Pixel[] pixels)
        {
            Pixel[] arr = new Pixel[size.width];
            Array.Copy(pixels, 1, arr, 0, size.width - 1);
            arr[size.width - 1] = imageController.GetPixel(currentPos.X + point.X, currentPos.Y + point.Y);
            return arr;
        }

        private Pixel[] updateMiddle(Point currentPos)
        {
            Pixel[] arr = new Pixel[size.height - 2];
            for (int j = 0; j < updateablePoints.middle.Length; j++)
            {
                arr[j] = imageController.GetPixel(currentPos.X + updateablePoints.middle[j].X, currentPos.Y + updateablePoints.middle[j].Y);
            }
            return arr;
        }

        private Pixel[] updateBottom(Point currentPos, Point point, Pixel[] mask)
        {
            Pixel[] arr = new Pixel[size.width];
            Array.Copy(mask, mask.Length - size.width + 1, arr, 0, size.width - 1);
            arr[size.width - 1] = imageController.GetPixel(currentPos.X + point.X, currentPos.Y + point.Y);
            return arr;
        }
    }
}
