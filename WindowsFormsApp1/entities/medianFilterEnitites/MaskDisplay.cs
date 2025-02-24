using System;
using System.Drawing;
using System.Windows.Forms;

namespace WindowsFormsApp1.entities.medianFilterEnitites
{

    public class MaskDisplay
    {
        private PictureBox pictureBox;
        private SolidBrush brush;
        private int squareSize;
        private int screenSize;
        private int maskWidth;
        private int maskHeight;
        private int offset;

        public MaskDisplay(PictureBox pictureBox) 
        {
            this.pictureBox = pictureBox;
            offset = 1;
            screenSize = pictureBox.Width;
            brush =  new SolidBrush(Color.LightSlateGray);
        }

        public void update(MaskType maskType)
        {
            setSquareSize(maskType.getSize());
            drawMask(maskType);
        }

        private void setSquareSize(Size maskSize)
        {
            int maxSquaresDimension = Math.Max(maskSize.Width, maskSize.Height);
            maskWidth = maskSize.Width;
            maskHeight = maskSize.Height;
            squareSize = (screenSize - maxSquaresDimension - offset) / maxSquaresDimension;
            int newWidth = maskWidth * (squareSize+offset) + offset;
            while (newWidth > screenSize) {
                squareSize--;
                newWidth = maskWidth * (squareSize + offset) + offset;
            }
            int newHeight = maskHeight * (squareSize + offset) + offset;
            while (newHeight > screenSize)
            {
                squareSize--;
                newHeight = maskHeight * (squareSize + offset) + offset;
            }
            if (maskSize.Width>maskSize.Height  )
            {
                pictureBox.Image = new Bitmap(newWidth, (squareSize+offset) * maskSize.Height + offset);
            }
            else if (maskWidth == maskHeight)
            {
                pictureBox.Image = new Bitmap(newWidth, newHeight);
            }
            else
            {
                pictureBox.Image = new Bitmap((squareSize + offset) * maskSize.Width + offset,newHeight);
            }
        }

        public void drawMask(MaskType maskType)
        {
            Point[] coordinates = maskType.getCoordinates();
            int newX, newY;
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

                    // Транслируем координаты пикселя маски в координаты класса Graphics  
                    newX = point.X + maskType.getSize().Width / 2;
                    newY = point.Y + maskType.getSize().Height / 2;

                    // Получаем координаты верхнего левого угла квадрата
                    newX *= (squareSize + offset);
                    newY *= (squareSize + offset);

                    g.FillRectangle(brush, new Rectangle(newX + offset, newY + offset, squareSize, squareSize));
                }
            }
        }
    }
}
