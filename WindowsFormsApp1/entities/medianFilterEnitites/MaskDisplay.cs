using System;
using System.Drawing;
using System.Windows.Forms;

namespace WindowsFormsApp1.entities.medianFilterEnitites
{

    public class MaskDisplay
    {
        PictureBox pictureBox;
        SolidBrush brush;
        private int squareSize;
        private int width;
        private int height;
        private int offset;
        private int side;
        public MaskDisplay(PictureBox pictureBox) 
        {
            this.pictureBox = pictureBox;
            offset = 1;
            side = pictureBox.Width;
            brush =  new SolidBrush(Color.LightSlateGray);
        }

        public void update(MaskSize maskSize)
        {
            calcSquareSize(maskSize);
            drawMask();
        }

        private void calcSquareSize(MaskSize maskSize)
        {
            int maxSquaresDimension = Math.Max(maskSize.width, maskSize.height);
            width = maskSize.width;
            height = maskSize.height;
            squareSize = (side - maxSquaresDimension - offset) / maxSquaresDimension;
            int newWidth = width * (squareSize+offset) + offset;
            while (newWidth > side) {
                squareSize--;
                newWidth = width * (squareSize + offset) + offset;
            }
            int newHeight = height * (squareSize + offset) + offset;
            while (newHeight > side)
            {
                squareSize--;
                newHeight = height * (squareSize + offset) + offset;
            }
            if (maskSize.width>maskSize.height)
            {
                pictureBox.Image = new Bitmap(newWidth, (squareSize+offset) * maskSize.height + offset);
            }
            else if (width == height)
            {
                pictureBox.Image = new Bitmap(newWidth, newHeight);
            }
            else
            {
                pictureBox.Image = new Bitmap((squareSize + offset) * maskSize.width + offset,newHeight);
            }
        }

        public void drawMask()
        {
            int innerHeight = height - 2;
            int x, y;
            using (Graphics g = Graphics.FromImage(pictureBox.Image))
            {
                for (int i = 0; i < width; i++)
                {
                    x = offset + squareSize * i + offset * i;
                    y = offset;
                    g.FillRectangle(brush, new Rectangle(x, y, squareSize, squareSize));
                }
                for(int i=1; i < innerHeight+1; i++)
                {
                    x = offset + squareSize * (width - 1) / 2 + offset * (width - 1) / 2;
                    y = offset + squareSize * i + offset * i;
                    if ((innerHeight+1) / 2 == i)
                    {
                        brush.Color = Color.Maroon;
                        g.FillRectangle(brush, new Rectangle(x, y, squareSize, squareSize));
                        brush.Color = Color.LightSlateGray;
                    }
                    else
                    {
                        g.FillRectangle(brush, new Rectangle(x, y, squareSize, squareSize));
                    }
                }
                for (int i = 0; i < width; i++)
                {
                    x = offset + squareSize * i + offset * i;
                    y = (height - 1) * (squareSize + offset) + offset;
                    g.FillRectangle(brush, new Rectangle(x, y, squareSize, squareSize));
                }
            }
        }
    }
}
