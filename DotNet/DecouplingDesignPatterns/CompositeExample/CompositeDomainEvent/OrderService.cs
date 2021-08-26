using CompositeExample.CompositeDomainEvent.Interfaces;
using CompositeExample.CompositeDomainEvent.Approved;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Threading.Tasks;

namespace CompositeExample.CompositeDomainEvent
{
    public class OrderService : IOrderService
    {        
        private readonly IEventHandler<OrderApproved> _handler;
        public OrderService(IEventHandler<OrderApproved> handler)
        {
            this._handler = handler;
        }
        public void ApproveOrder(Order order)
        {
            this.UpdateOrder(order);
            this._handler.Handle(new OrderApproved(order.Id));
        }

        public void UpdateOrder(Order order)
        {
            //...
        }
    }
}
