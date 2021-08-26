using System;
using System.Collections.Generic;
using System.Linq;
using System.Threading.Tasks;

namespace CompositeExample.CompositeDomainEvent.Approved
{
    public class OrderApproved
    {
        public readonly Guid OrderId;
        public OrderApproved(Guid orderId)
        {
            this.OrderId = orderId;
        }
    }
}
