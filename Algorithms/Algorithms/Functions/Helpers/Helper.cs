using Algorithms.DataClasses;
using System;
using System.Collections.Generic;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Algorithms.Functions.Helpers
{
    public static class Helper
    {

        #region Calculate Distance  
        /// <summary>
        /// Get distance between 2 PLACE data class objects
        /// </summary>
        /// <param name="p1">The first PLACE</param>
        /// <param name="p2">The second PLACE</param>
        /// <returns>The distance as a float</returns>
        public static float GetDistance(PLACE p1, PLACE p2)
        {
            return GetDistance(p1.point, p2.point);
        }
             
        public static float GetDistance(Point p1, Point p2)
        {
            float calculatedDistance = 0.0f;

            float x1 = p1.X;
            float x2 = p2.X;
            float y1 = p1.Y;
            float y2 = p2.Y;

            calculatedDistance = GetDistance(x1, x2, y1, y2);

            return calculatedDistance;
        }

        public static float GetDistance(float x1, float x2, float y1, float y2)
        {
            float calculatedDistance = 0.0f;
            calculatedDistance = ((x1 - x2) * (x1 - x2) + (y1 - y2) * (y1 - y2));

            return calculatedDistance;
        }
        #endregion

        #region GUI Helper

        public static Point HalfwayPoint(LINE lin)
        {
            return HalfwayPoint(lin.startPlace, lin.endPlace);
        }

        public static Point HalfwayPoint(PLACE p1, PLACE p2)
        {
            return HalfwayPoint(p1.point, p2.point);
        }

        public static Point HalfwayPoint(Point p1, Point p2)
        {
            return new Point(Halfway(p1.Y, p2.Y), Halfway(p1.X, p2.X));
        }

        public static int Halfway(int i1, int i2)
        {
            int p = 0;

            if(i1 == i2)
            {
                return i1;
            }
            else 
            {
                return (int)((i1 + i2) / 2);
            }

            return p;
        }

        #endregion

    }


}
