using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace MontyHall
{
    class Program
    {
        static void Main(string[] args)
        {
            DoorContainer container = new DoorContainer();            
            container.Randomize();
        }
    }
}
