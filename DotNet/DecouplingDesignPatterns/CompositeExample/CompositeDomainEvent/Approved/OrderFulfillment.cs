using CompositeExample.CompositeDomainEvent.Interfaces;
using CompositeExample.CompositeDomainEvent.Approved.Interfaces;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Threading.Tasks;

namespace CompositeExample.CompositeDomainEvent.Approved
{
    public class OrderFulfillment : IEventHandler<OrderApproved>
    {
        private readonly ILocationService _locationService;
        private readonly IInventoryManagement _inventoryManagement;
        public OrderFulfillment(ILocationService locationService, IInventoryManagement inventoryManagement)
        {
            this._locationService = locationService;
            this._inventoryManagement = inventoryManagement;
        }
        public void Handle(OrderApproved e)
        {
            this._locationService.FindWarehouses(e);
            this._inventoryManagement.NotifyWarehouses(e);
        }
    }
}
