using CompositeExample.CompositeDomainEvent.Interfaces;
using CompositeExample.CompositeDomainEvent.Approved.Interfaces;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Threading.Tasks;

namespace CompositeExample.CompositeDomainEvent.Approved
{
    public class AccountingNotifier : IEventHandler<OrderApproved>
    {
        private readonly IBillingSystem billingSystem;

        public AccountingNotifier(IBillingSystem billingSystem)
        {
            this.billingSystem = billingSystem;
        }

        public void Handle(OrderApproved e)
        {
            this.billingSystem.Approve(e);
        }
    }
}
