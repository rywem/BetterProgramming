using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Algorithms.Request
{
    public class BaseRequest
    {
        public List<string> errors { get; set; }

        public BaseRequest()
        {
            this.errors = new List<string>();
        }

        public BaseRequest(string error)
        {
            this.errors.Add(error);
        }
    }
}
