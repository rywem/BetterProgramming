using CompositeExample.CompositeDomainEvent.Approved.Interfaces;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Threading.Tasks;

namespace CompositeExample.CompositeDomainEvent.Approved
{
    public class BillingSystem : IBillingSystem
    {
        public void Approve(OrderApproved e)
        {
            Console.WriteLine("BillingSystem.Approve()");
        }
    }
}
