using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace BusinessLib.Mocking
{
    class Program
    {
        static void Main(string[] args)
        {
            var service = new VideoService();
            var title = service.ReadVideoTitle(new FileReader());
        }
    }
}
