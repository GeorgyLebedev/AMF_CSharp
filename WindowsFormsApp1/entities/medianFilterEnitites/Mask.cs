using System;
using System.Drawing;
using System.Linq;

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

        public void fill(Point currentPos, ref Pixel[] pixels)
        {
            Pixel[] newMaskPixels = new Pixel[maskType.getPixelsCount()];
            int index = 0;
            foreach (Point maskPoint in maskType.getCoordinates())
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
            int maskWidth = maskType.maskSize.width;
            int maskHeight = maskType.maskSize.height;
            int imgWidth = imageController.width;
            int imgHeight = imageController.height;
            int x = currentPos.X;
            int y = currentPos.Y;
            bool prevUpdated = false;
            if (x > maskWidth / 2 && y > maskHeight / 2 && x < imgWidth - maskWidth / 2 && y < imgHeight - maskHeight / 2)
            {
                Pixel[] newMaskPixels = new Pixel[maskType.getPixelsCount()];
                for (int i = 0; i < newMaskPixels.Length; i++)
                {
                    if (maskType.isUpdateableIndex(i))
                    {
                        Point point = maskType.getCoordinate(i);
                        newMaskPixels[i] = imageController.GetPixel(currentPos.X + point.X, currentPos.Y + point.Y);
                        prevUpdated = true;
                    }
                    else
                    {
                        if (prevUpdated)
                        {
                            newMaskPixels[i] = pixels[i + 2];
                            prevUpdated = false;
                        }
                        else
                        {
                            newMaskPixels[i] = pixels[i + 1];
                        }
                    }
                }
                pixels = newMaskPixels;
            }
            else
            {
                fill(currentPos, ref pixels);
            }
        }
    }
}
