using System;
using System.Collections.Generic;
using System.Linq;
using System.Threading.Tasks;

namespace CompositeExample.CompositeDomainEvent.Interfaces
{
    public interface IOrderService
    {
        void ApproveOrder(Order order);
    }
}
