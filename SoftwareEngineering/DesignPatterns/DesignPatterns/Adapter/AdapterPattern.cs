using System;
using System.Collections.Generic;
using System.Collections.ObjectModel;
using static System.Console;
namespace DesignPatterns.Adapter
{
    public class Point
    {
        public int X, Y;

        public Point(int x, int y)
        {
            X = x;
            Y = y;
        }
    }

    public class Line
    {
        public Point Start, End;
        public Line(Point start, Point end)
        {
            if (start == null)
                throw new ArgumentNullException(paramName: nameof(start));
            if (end == null)
                throw new ArgumentNullException(paramName: nameof(end));
            Start = start;
            End = end;
        }
    }
    public class VectorObject : Collection<Line>
    {
        
    }
    public class VectorRectangle : VectorObject
    {
        public VectorRectangle(int x, int y, int width, int height)
        {
            Add(new Line(new Point(x, y), new Point(x + width, y)));
            Add(new Line(new Point(x + width, y), new Point(x + width, y + height)));
            Add(new Line(new Point(x, y), new Point(x, y + height)));
            Add(new Line(new Point(x, y + height), new Point(x + width, y + height)));
        }
    }

    public class LineToPointAdapter : Collection<Point>
    {
        
    }
    public class AdapterPattern
    {
        private static readonly List<VectorObject> vectorObjects = new List<VectorObject>
        {
            new VectorRectangle(1,1, 10, 10),
            new VectorRectangle(3,3,6,6)
        }
        public void DrawPoint(Point p)
        {
            if (p == null)
            {
                throw new ArgumentNullException(nameof(p));
            }

            Write(".");
        }
    }
}
