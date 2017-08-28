using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace LearnAttributes
{
    public class PCIAttribute : System.Attribute
    {
        private bool StoragePermitted;

        public PCIAttribute()
        {

        }

        public PCIAttribute(bool StoragePermitted)
        {
            this.StoragePermitted = StoragePermitted;
        }
    }
}
