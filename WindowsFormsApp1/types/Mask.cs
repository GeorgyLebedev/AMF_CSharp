using System.Drawing;


namespace WindowsFormsApp1.types
{
    public class MaskSize
    {
        public readonly byte width;
        public readonly byte height;

        public MaskSize(byte width, byte height)
        {
            this.width = width;
            this.height = height;
        }

    }

    public class MaskUpdateablePoints
    {
        public Point top;
        public Point[] middle;
        public Point bottom;
    }

}
