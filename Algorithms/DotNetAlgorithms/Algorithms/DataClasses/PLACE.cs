using System;
using System.Collections.Generic;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Algorithms.DataClasses
{
    /// <summary>
    /// Originally wanted to call this class "point" but I didn't want to confuse it with System.Drawing.Point
    /// </summary>
    public class PLACE
    {
        //public System.Drawing.Pen pen { get; set; } 
        public int x { get; set; }
        public int y { get; set; }
        public float width { get; set; } = 3.0f;
        public float height { get; set; } = 3.0f;
        public bool unvisited { get; set; } = true;       

        public Point point
        {
            get
            {
                return new Point(this.x, this.y);
            }                            
        }

        /// <summary>
        /// Returns a list of max
        /// </summary>
        /// <param name="maxWidth">Max width of the canvas</param>
        /// <param name="maxHeight">Max height of the canvas</param>
        /// <returns></returns>
        public List<PLACE> RandomPoints(int maxWidth, int maxHeight)
        {
            DateTime startTime = DateTime.Now;
            List<PLACE> places = new List<PLACE>();
            Random rand = new Random();
            int count = rand.Next(10, 35);

            for (int i = 0; i < count; i++)
            {
                PLACE point = new PLACE();

                point.width = 3.0f;
                point.height = 3.0f;

                bool checkDupes = false;
                do
                {
                    point.y = rand.Next(1, maxHeight - (int)point.height); 
                    point.x = rand.Next(1, maxWidth - (int)point.width);

                    if (places != null || places.Count > 0 )
                    {
                        //Check that there are no duplicate points at this position. We want our points spread out.
                        checkDupes = places.Exists(p => (point.y <= p.y + point.height && point.y >= p.y) && 
                                                        (point.x <= p.x + point.width && point.x >= p.x));
                    }

                } while (checkDupes);
                                
                places.Add(point);
            }

            Program.output.Add(new Output() { startTime = startTime, endTime = DateTime.Now, title = "Random Points",
                                            message = "Generated new list", status = "Completed", type = "Simulation Setup",
                                            elements = places.Count});            
            return places;
        }
    }
}
