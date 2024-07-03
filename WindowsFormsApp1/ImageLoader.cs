using System;
using System.Drawing;
using System.Drawing.Imaging;
using System.Runtime.InteropServices;
using System.Windows.Forms;

namespace WindowsFormsApp1
{
    public partial class ImageLoader
    {
        private Bitmap image;
        private ProgressBar progressBar;
        public ImageLoader(string filename, ProgressBar progressBar)
        {
            this.image = new Bitmap(filename);
            this.progressBar = progressBar;
            this.progressBar.Visible = true;
            this.progressBar.Minimum = 0;
            this.progressBar.Maximum = image.Width*image.Height;
        }

        public Bitmap Load()
        {
            var tempImage = new Bitmap(this.image.Width, this.image.Height);
            BitmapData rawImageData = this.image.LockBits(new Rectangle(0, 0, this.image.Width, this.image.Height), ImageLockMode.ReadOnly, PixelFormat.Format24bppRgb);
            BitmapData imageData = tempImage.LockBits(new Rectangle(0, 0, tempImage.Width, tempImage.Height), ImageLockMode.WriteOnly, PixelFormat.Format24bppRgb);
            IntPtr rawImagePointer = rawImageData.Scan0;
            IntPtr imagePointer = imageData.Scan0;
            byte[] rawImageBytes = new byte[3 * this.image.Width * this.image.Height];
            byte[] imageBytes = new byte[3 * image.Width * image.Height];
            Marshal.Copy(rawImagePointer, rawImageBytes, 0, rawImageBytes.Length);
            double kr = 0.2126;
            double kg = 0.7152;
            double kb = 0.0722;
            int y;
            for (int i = 0; i < this.image.Width * this.image.Height * 3; i += 3)
            {
                y = Convert.ToInt32(rawImageBytes[i] * kr + rawImageBytes[i + 1] * kg + rawImageBytes[i + 2] * kb);
                imageBytes[i] = imageBytes[i + 1] = imageBytes[i + 2] = Convert.ToByte(y);
                if (i % 600 == 0)
                    this.progressBar.Value += 200;
            }
            Marshal.Copy(imageBytes, 0, imagePointer, imageBytes.Length);
            this.image.UnlockBits(rawImageData);
            tempImage.UnlockBits(imageData);
            this.progressBar.Visible = false;
            return tempImage;
        }
    }
}
