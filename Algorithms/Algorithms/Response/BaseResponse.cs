using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Algorithms.Response
{
    public class BaseResponse
    {

        public List<string> errors { get; set; }

        public BaseResponse()
        {
            this.errors = new List<string>();
        }

        public BaseResponse(string error)
        {
            this.errors.Add(error);
        }
    }
}
