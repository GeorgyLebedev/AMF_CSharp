using System;
using System.Drawing;
using System.Drawing.Imaging;
using System.Runtime.InteropServices;

namespace WindowsFormsApp1
{
    public class Pixel
    {
       public byte r, g, b;
       public int rgbSum
       {
            get
            {
                return  r + g + b;
            }
       }
    }
    public class ImageController
    {
        public readonly int width;
        public readonly int height;
        private byte[] pixels;
        private byte[] filteredPixels;
        private Bitmap imgSrc;

        public ImageController(Bitmap src) {
            width = src.Width;
            height = src.Height;
            imgSrc = src;
            pixels = new byte[4 * width * height];
            filteredPixels = new byte[4 * width * height];
            copyPixels(imgSrc, pixels);
            copyPixels(imgSrc, filteredPixels);
        }

        private void copyPixels(Bitmap src, byte[] buffer)
        {
            Rectangle rect = new Rectangle(0, 0, width, height);
            BitmapData bitmapData = src.LockBits(rect, ImageLockMode.ReadOnly, PixelFormat.Format32bppArgb);
            IntPtr ptr = bitmapData.Scan0;
            Marshal.Copy(ptr, buffer, 0, buffer.Length);
            src.UnlockBits(bitmapData);
        }

        public Bitmap updateImageData()
        {
            Rectangle rect = new Rectangle(0, 0, width, height);
            BitmapData bitmapData = imgSrc.LockBits(rect, ImageLockMode.WriteOnly, PixelFormat.Format32bppArgb);
            IntPtr ptr = bitmapData.Scan0;
            Marshal.Copy(filteredPixels, 0, ptr, filteredPixels.Length);
            imgSrc.UnlockBits(bitmapData);
            return imgSrc;
        }

        public bool IsExistPixel(int x, int y)
        {
            return x>=0 && y>=0 && x<width && y<height;
        }

        public Pixel GetPixel(int x, int y)
        {
            int i = y * width + x;
            Pixel px = new Pixel();
            px.r = pixels[4 * i];
            px.g = pixels[4 * i + 1];
            px.b = pixels[4 * i + 2];
            return px;
        }

        public int getPixelMiddleValue(int x, int y)
        {
            int i = y * width + x;
            return (pixels[4 * i] + pixels[4 * i + 1] + pixels[4 * i + 2])/3;
        }

        public void SetPixel(int x, int y, Pixel pixel)
        {
            int i = y * width + x;
            filteredPixels[4 * i] = pixel.b;
            filteredPixels[4 * i + 1] = pixel.g;
            filteredPixels[4 * i + 2] = pixel.r;
        }

        public void SetPixelColor(int x, int y, Color color)
        {
            int i = y * width + x;
            filteredPixels[4 * i] = color.B;
            filteredPixels[4 * i + 1] = color.G;
            filteredPixels[4 * i + 2] = color.R;
        }
    }
}
