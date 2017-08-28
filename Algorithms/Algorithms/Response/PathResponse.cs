using Algorithms.DataClasses;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Algorithms.Response
{
    public class PathResponse : BaseResponse
    {
        public float totalDistance { get; set; }
        public List<LINE> lines { get; set; }

        public PathResponse(string errorMsg)
        {
            this.errors = new List<string>();
            this.errors.Add(errorMsg);
            this.totalDistance = 0.0f;
            this.lines = null;
        }

        public PathResponse()
        {
            this.totalDistance = 0.0f;
            this.lines = new List<LINE>();
            errors = null;
        }
        
    }
}
