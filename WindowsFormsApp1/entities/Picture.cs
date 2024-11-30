using System;
using System.Drawing.Imaging;
using System.Drawing;
using System.Runtime.InteropServices;
using System.Windows.Forms;

namespace WindowsFormsApp1.entities
{
    public class Picture
    {
        PictureBox box;
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

        public void firstSetImg(Bitmap img)
        {
            box.Image = img;
            grayscaleImage();
            update();
        }

        public void setImg(Bitmap img)
        {
            box.Image = img;
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

        public void RotateByOrientation(bool toVertical)
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
            box.Image= new Bitmap(tempImage);
        }
    }
}
