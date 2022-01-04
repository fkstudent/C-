// See https://aka.ms/new-console-template for more information

namespace Lab2
{
    public class Shape
    {
        private int X;
        private int Y;
        private int Height;
        private int Width;

        public Shape(int x, int y, int height, int width)
        {
            X = x;
            Y = y;
            Height = height;
            Width = width;
        }

        public Shape()
        {
        }

        public virtual void Draw()
        {
        }
    }
}