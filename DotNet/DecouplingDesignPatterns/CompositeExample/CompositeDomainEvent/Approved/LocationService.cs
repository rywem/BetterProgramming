using System;
using System.Collections.Generic;
using System.Linq;
using System.Threading.Tasks;
using CompositeExample.CompositeDomainEvent.Approved.Interfaces;

namespace CompositeExample.CompositeDomainEvent.Approved
{
    public class LocationService : ILocationService
    {
        public void FindWarehouses(OrderApproved order)
        {
            Console.WriteLine("LocationService.FindWarehouses()");
        }
    }
}
