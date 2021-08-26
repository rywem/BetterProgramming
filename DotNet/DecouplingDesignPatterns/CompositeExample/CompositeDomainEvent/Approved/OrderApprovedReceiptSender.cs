using CompositeExample.CompositeDomainEvent.Interfaces;
using CompositeExample.CompositeDomainEvent.Approved.Interfaces;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Threading.Tasks;

namespace CompositeExample.CompositeDomainEvent.Approved
{
    public class OrderApprovedReceiptSender : IEventHandler<OrderApproved>
    {
        private readonly IMessageService messageService;

        public OrderApprovedReceiptSender(IMessageService messageService)
        {
            this.messageService = messageService;
        }
        public void Handle(OrderApproved e)
        {
            messageService.SendMessage(e);
        }
    }
}
