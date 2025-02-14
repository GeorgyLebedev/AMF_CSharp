using System;
using System.Drawing;
using System.Windows.Forms;

namespace WindowsFormsApp1.entities.medianFilterEnitites
{

    public class MaskDisplay
    {
        PictureBox pictureBox;
        SolidBrush brush;
        MaskType maskType;
        private int squareSize;
        private int width;
        private int height;
        private int offset;
        private int side;
        public MaskDisplay(PictureBox pictureBox, MaskType maskType) 
        {
            this.pictureBox = pictureBox;
            this.maskType = maskType;
            offset = 1;
            side = pictureBox.Width;
            brush =  new SolidBrush(Color.LightSlateGray);
        }

        public void update(MaskType maskType)
        {
            this.maskType = maskType;
            calcSquareSize(maskType.getSize());
            drawMask(maskType);
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

        public void drawMask(MaskType maskType)
        {
            Point[] coordinates = maskType.getCoordinates();
            int x, y;
            using (Graphics g = Graphics.FromImage(pictureBox.Image))
            {
                foreach (Point point in coordinates)
                {
                    if(point.X == 0 && point.Y == 0)
                    {
                        brush.Color = Color.Maroon;
                    }
                    else
                    {
                        brush.Color = Color.LightSlateGray;
                    }
                    x = point.X + maskType.getSize().width / 2;
                    y = point.Y + maskType.getSize().height / 2;
                    g.FillRectangle(brush, new Rectangle(x * (squareSize+offset) + offset, y * (squareSize + offset) + offset, squareSize, squareSize));
                }
            }
        }
    }
}
