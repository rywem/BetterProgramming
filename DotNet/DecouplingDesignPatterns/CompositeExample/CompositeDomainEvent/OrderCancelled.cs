using System;
using System.Collections.Generic;
using System.Linq;
using System.Threading.Tasks;

namespace CompositeExample.CompositeDomainEvent
{
    public class OrderCancelled
    {
        public readonly Guid OrderId;
        public OrderCancelled(Guid orderId)
        {
            this.OrderId = orderId;
        }
    }
}
