using System;
namespace DesignPatterns.SOLID
{
    public class Rectangle
    {
        public virtual int Width { get; set; }
        public virtual int Height { get; set; }

        static public int Area(Rectangle r) => r.Width * r.Height;

        public Rectangle()
        {
        }
        public Rectangle(int width, int height)
        {
            Width = width;
            Height = height;
        }

        public override string ToString()
        {
            return $"{nameof(Width)}: {Width}, {nameof(Height)}: {Height}";
        }
    }

    public class Square : Rectangle
    {
        public override int Width 
        {
            set { base.Width = base.Height = value; }
        }
        public override int Height
        {
            set { base.Height = base.Width = value; }
        }
    }

    public class LRunner
    {
        public void Run()
        {
            Rectangle rc = new Rectangle(2, 3);
            Console.WriteLine($"{rc} has area {Rectangle.Area(rc)}");
        }
    }
}
