using System;
namespace DesignPatterns.Factories
{


    public static class PointFactory
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

    /// <summary>
    /// FactoryMethod
    /// </summary>
    public class Point
    {
        private double x, y;
        internal Point(double x, double y)
        {
            this.x = x;
            this.y = y;
        }
        public override string ToString()
        {
            return $"{nameof(x)}: {x}, {nameof(y)}: {y}";
        }
    }
    public class FactoryDemo
    {
        public void Run()
        {
            var point = PointFactory.NewPolarPoint(1.0, Math.PI / 2);
            Console.WriteLine(point);
        }
    }
}
