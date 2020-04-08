using System;
using System.Collections.Generic;
using System.Text;
using System.Linq;
namespace FuncLambda.Example
{
    public class RunExample
    {
        public void Run()
        {
            List<Customer> customers = new List<Customer>()
            {
                new Customer(){ Name ="Mary" },
                new Customer(){ Name ="Lisa" },
                new Customer(){ Name ="Roger" },
                new Customer(){ Name ="JoAnn" },
                new Customer(){ Name ="Stephen" }
            };


            var custs = (from c in customers
                         select c)
                         .SetAccountT(c => c.Account.Name = "TestT")
                         .ToList();

            foreach ( var item in custs )
            {
                Console.WriteLine($"{item.Name},  Account {item.Account.Name}");
            }
        }        
    }
}
