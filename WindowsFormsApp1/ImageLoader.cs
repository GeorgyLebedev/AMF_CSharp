using System;
using System.Drawing;
using System.Drawing.Imaging;
using System.Runtime.InteropServices;

namespace WindowsFormsApp1
{
    public class ImageLoader
    {
        private Bitmap image;
        public ImageLoader(string filename)
        {
            image = new Bitmap(filename);
            RotateImageAccordingToExifOrientation(image);
        }

        public Bitmap Load()
        {
            var tempImage = new Bitmap(image.Width, image.Height);
            BitmapData rawImageData = image.LockBits(new Rectangle(0, 0, image.Width, image.Height), ImageLockMode.ReadOnly, PixelFormat.Format24bppRgb);
            BitmapData imageData = tempImage.LockBits(new Rectangle(0, 0, tempImage.Width, tempImage.Height), ImageLockMode.WriteOnly, PixelFormat.Format24bppRgb);
            IntPtr rawImagePointer = rawImageData.Scan0;
            IntPtr imagePointer = imageData.Scan0;
            byte[] rawImageBytes = new byte[3 * image.Width * image.Height];
            byte[] imageBytes = new byte[3 * image.Width * image.Height];
            Marshal.Copy(rawImagePointer, rawImageBytes, 0, rawImageBytes.Length);
            double kr = 0.2126;
            double kg = 0.7152;
            double kb = 0.0722;
            int y;
            int pixelsCount = image.Width * image.Height * 3;
            for (int i = 0; i < pixelsCount; i += 3)
            {
                y = Convert.ToInt32(rawImageBytes[i] * kr + rawImageBytes[i + 1] * kg + rawImageBytes[i + 2] * kb);
                imageBytes[i] = imageBytes[i + 1] = imageBytes[i + 2] = Convert.ToByte(y);
            }
            Marshal.Copy(imageBytes, 0, imagePointer, imageBytes.Length);
            image.UnlockBits(rawImageData);
            tempImage.UnlockBits(imageData);
            return tempImage;
        }

        public static void RotateImageAccordingToExifOrientation(Bitmap img)
        {
            var prop = img.GetPropertyItem(0x0112);
            var orientation = (int)prop.Value[0];
            switch (orientation)
            {
                case 1:
                    break;
                case 2:
                    img.RotateFlip(RotateFlipType.RotateNoneFlipX);
                    break;
                case 3:
                    img.RotateFlip(RotateFlipType.Rotate180FlipNone);
                    break;
                case 4:
                    img.RotateFlip(RotateFlipType.Rotate180FlipX);
                    break;
                case 5:
                    img.RotateFlip(RotateFlipType.Rotate90FlipX);
                    break;
                case 6:
                    img.RotateFlip(RotateFlipType.Rotate90FlipNone);
                    break;
                case 7:
                    img.RotateFlip(RotateFlipType.Rotate270FlipX);
                    break;
                case 8:
                    img.RotateFlip(RotateFlipType.Rotate270FlipNone);
                    break;
                default:
                    break;
            }
        }
    }
}
