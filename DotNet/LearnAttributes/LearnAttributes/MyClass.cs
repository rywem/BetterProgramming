using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace LearnAttributes
{
    class MyClass
    {
        [Map("ReferenceNumber", ServiceCall = ServiceCall.CreditCardSale | ServiceCall.CreditCardForce )]
        public string Item { get; set; }
    }
}
