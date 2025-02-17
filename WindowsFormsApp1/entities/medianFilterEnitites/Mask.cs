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
            this.maskType = maskType;
            this.imageController = imageController;
        }
   
        private ImageController imageController;
        private MaskType maskType;

        public void update(Point currentPos, ref Pixel[] pixels)
        {
            bool isInBounds = isFullMask(currentPos, maskType.getSize(), imageController.getSize());
            if (isInBounds)
            {
                int x = currentPos.X;
                int y = currentPos.Y;
                Point[] maskCoordinates = maskType.getCoordinates();
                int[] staticIndexes = maskType.getStaticIndexes();
                int[] dynamicIndexes = maskType.getDynamicUndexes();
                Pixel[] newMaskPixels = new Pixel[maskType.getPixelsCount()];
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
                fill(currentPos, ref pixels);
            }
        }

        public void fill(Point currentPos, ref Pixel[] pixels)
        {
            Pixel[] newMaskPixels = new Pixel[maskType.getPixelsCount()];
            int index = 0;
            foreach (Point maskPoint in maskType.getCoordinates())
            {
                if (imageController.isExistPixel(currentPos.X + maskPoint.X, currentPos.Y + maskPoint.Y))
                {
                    Pixel pixel = imageController.getPixel(currentPos.X + maskPoint.X, currentPos.Y + maskPoint.Y);
                    newMaskPixels[index] = pixel;
                    index++;
                }
            }
            pixels = newMaskPixels.Take(index).ToArray();
        }

        private bool isFullMask(Point pos, Size maskSize, Size imgSize)
        {
            int x = pos.X;
            int y = pos.Y;
            int maskWidth = maskSize.Width;
            int maskHeight = maskSize.Height;
            int imgWidth = imgSize.Width;
            int imgHeight = imgSize.Height;
            return x > maskWidth / 2 && y > maskHeight / 2 && x < imgWidth - maskWidth / 2 && y < imgHeight - maskHeight / 2;
        }
    }
}
