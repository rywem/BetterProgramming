using System;
namespace DesignPatterns.Factories
{
    /// <summary>
    /// FactoryMethod
    /// </summary>
    public class Point
    {
        // alternative approach:
        //public static PointFactory Factory => new PointFactory();
        private double x, y;

        public static Point Origin => new Point(0, 0); //creates a new instance every time accessed
        public static Point Origin2 = new Point(0, 0); //better - creates a single instance that is re-used
        internal Point(double x, double y)
        {
            this.x = x;
            this.y = y;
        }
        public override string ToString()
        {
            return $"{nameof(x)}: {x}, {nameof(y)}: {y}";
        }
        public static class Factory
        {
            /// <summary>
            /// factory method design pattern
            /// </summary>
            /// <returns>The cartesian point.</returns>
            /// <param name="x">The x coordinate.</param>
            /// <param name="y">The y coordinate.</param>
            public static Point NewCartesianPoint(double x, double y)
            {
                return new Point(x, y);
            }

            public static Point NewPolarPoint(double rho, double theta)
            {
                return new Point(rho * Math.Cos(theta), rho * Math.Sin(theta));
            }
        }
    }
    public class FactoryDemo
    {
        public void Run()
        {
            var point = Factory.NewPolarPoint(1.0, Math.PI / 2);
            Console.WriteLine(point);
        }
    }
}
