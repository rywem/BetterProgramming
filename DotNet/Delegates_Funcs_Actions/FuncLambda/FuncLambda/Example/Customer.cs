using System;
using System.Collections.Generic;
using System.Text;

namespace FuncLambda.Example
{
    public class Customer
    {
        public string Name { get; set; }
        public Account Account { get; set; }

        public Customer()
        {
            this.Account = new Account();
        }
    }
}
