using System;
using System.Drawing;
using System.Linq;
using System.Reflection;

namespace WindowsFormsApp1.entities.medianFilterEnitites
{
    public class Mask
    {

        public Mask(MaskType maskType, ImageController imageController)
        {
            this.imageController = imageController;
            maskCoordinates = maskType.getCoordinates();
            staticIndexes = maskType.getStaticIndexes();
            dynamicIndexes = maskType.getDynamicUndexes();
            pixelsCount = maskType.getPixelsCount();
            maskSize = maskType.getSize();
            halfMaskWidth = maskSize.Width / 2;
            halfMaskHeight = maskSize.Height / 2;
        }
   
        private ImageController imageController;
        private readonly Point[] maskCoordinates;
        private readonly int[] staticIndexes;
        private readonly int[] dynamicIndexes;
        private readonly int pixelsCount;
        private readonly Size maskSize;
        private readonly int halfMaskWidth;
        private readonly int halfMaskHeight;

        public void update(Point currentPosition, ref Pixel[] pixels)
        {
            bool isInBounds = isFullMask(currentPosition, maskSize, imageController.getSize());
            if (isInBounds)
            {
                int x = currentPosition.X;
                int y = currentPosition.Y;
                Pixel[] newMaskPixels = new Pixel[pixelsCount];
                foreach (int index in dynamicIndexes)
                {
                    Point point = maskCoordinates[index];
                    newMaskPixels[index] = imageController.getPixel(x + point.X, y + point.Y);
                }
                foreach (int index in staticIndexes)
                {
                    newMaskPixels[index] = pixels[index + 1];
                }
                pixels = newMaskPixels;
            }
            else
            {
                pixels = fill(currentPosition);
            }
        }

        public Pixel[] fill(Point currentPosition)
        {
            Pixel[] newMaskPixels = new Pixel[pixelsCount];
            int index = 0;
            foreach (Point maskPoint in maskCoordinates)
            {
                if (imageController.isExistPixel(currentPosition.X + maskPoint.X, currentPosition.Y + maskPoint.Y))
                {
                    Pixel pixel = imageController.getPixel(currentPosition.X + maskPoint.X, currentPosition.Y + maskPoint.Y);
                    newMaskPixels[index] = pixel;
                    index++;
                }
            }
            Array.Resize(ref newMaskPixels, index);
            return newMaskPixels;
        }

        private bool isFullMask(Point position, Size maskSize, Size imageSize)
        {
            int x = position.X;
            int y = position.Y;
            int maskWidth = maskSize.Width;
            int maskHeight = maskSize.Height;
            int imgWidth = imageSize.Width;
            int imgHeight = imageSize.Height;
            return x > halfMaskWidth && y > halfMaskHeight && x < imgWidth - halfMaskWidth && y < imgHeight - halfMaskHeight;
        }
    }
}
