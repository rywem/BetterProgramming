using Algorithms.DataClasses;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Algorithms.Request
{
    public class PathRequest : BaseRequest
    {
        public List<PLACE> places { get; set; }
        public int startingPoint { get; set; } = 0;
        public PathRequest()
        {
            this.places = null;
        }
        public PathRequest(List<PLACE> places)
        {
            this.places = places;
        }   
    }
}
