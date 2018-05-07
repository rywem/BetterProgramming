using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Drawing;
namespace Algorithms.DataClasses
{
    public class LINE
    {
        public PLACE startPlace { get; set; }
        public PLACE endPlace { get; set; }
        /// <summary>
        /// The number of the sequence.
        /// </summary>
        public int position { get; set; }
        public float distance { get; set; }        
    }
}
