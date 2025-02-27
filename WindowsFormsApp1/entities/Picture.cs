using System;
using System.Drawing.Imaging;
using System.Drawing;
using System.Runtime.InteropServices;
using System.Windows.Forms;

namespace WindowsFormsApp1.entities
{
    public class Picture
    {
        private PictureBox box;
        public bool isVertical
        {
            get
            {
                return box.Image.Width < box.Image.Height;
            }
        }

        public Picture(PictureBox pictureBox)
        {
            box = pictureBox;   
        }

        public void setImage(Bitmap image, bool isNeedGrayscale=false)
        {
            box.Image = image;
            box.Enabled = true;
            if (isNeedGrayscale)
            {
                grayscaleImage();
            }
            update();
        }

        public void update()
        {
            box.Invalidate();
        }

        public void save(string fileName, ImageFormat imageFormat)
        {
            box.Image.Save(fileName, imageFormat);
        }

        public void clear()
        {
            box.Image = box.InitialImage;
            if (isVertical) {
                rotateByOrientation(false);
            }
            box.Enabled = false;
        }

        public void rotateByOrientation(bool toVertical)
        {
            if (toVertical)
            {
                box.Image.RotateFlip(RotateFlipType.Rotate270FlipNone);
            }
            else
            {
                box.Image.RotateFlip(RotateFlipType.Rotate90FlipNone);
            }
        }

        public void rotate90()
        {
            box.Image.RotateFlip(RotateFlipType.Rotate90FlipNone);
            update();
        }

        private void grayscaleImage()
        {
            Bitmap image = (Bitmap)box.Image;
            Bitmap newImage = new Bitmap(image.Width, image.Height);
            BitmapData imageData = image.LockBits(new Rectangle(0, 0, image.Width, image.Height), ImageLockMode.ReadOnly, PixelFormat.Format24bppRgb);
            BitmapData newImageData = newImage.LockBits(new Rectangle(0, 0, newImage.Width, newImage.Height), ImageLockMode.WriteOnly, PixelFormat.Format24bppRgb);
            IntPtr imageDataPointer = imageData.Scan0;
            IntPtr newImageDataPointer = newImageData.Scan0;
            byte[] imageBytes = new byte[3 * image.Width * image.Height];
            byte[] newImageBytes = new byte[3 * image.Width * image.Height];
            Marshal.Copy(imageDataPointer, imageBytes, 0, imageBytes.Length);
            double kr = 0.2126;
            double kg = 0.7152;
            double kb = 0.0722;
            byte y;
            for (int i = 0; i < imageBytes.Length; i += 3)
            {
                y = (byte)(imageBytes[i] * kr + imageBytes[i + 1] * kg + imageBytes[i + 2] * kb);
                newImageBytes[i] = newImageBytes[i + 1] = newImageBytes[i + 2] = y;
            }
            Marshal.Copy(newImageBytes, 0, newImageDataPointer, newImageBytes.Length);
            image.UnlockBits(imageData);
            newImage.UnlockBits(newImageData);
            box.Image = new Bitmap(newImage);
        }
    }
}
