using CompositeExample.CompositeDomainEvent.Approved.Interfaces;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Threading.Tasks;

namespace CompositeExample.CompositeDomainEvent.Approved
{
    public class InventoryManagement : IInventoryManagement
    {
        public void NotifyWarehouses(OrderApproved order)
        {
            Console.WriteLine("InventoryManagement.NotifyWarehouses()");
        }
    }
}
