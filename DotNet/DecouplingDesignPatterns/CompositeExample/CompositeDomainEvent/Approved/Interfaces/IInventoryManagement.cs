using System;
using System.Collections.Generic;
using System.Linq;
using System.Threading.Tasks;

namespace CompositeExample.CompositeDomainEvent.Approved.Interfaces
{
    public interface IInventoryManagement
    {
        void NotifyWarehouses(OrderApproved order);
    }
}
