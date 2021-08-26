using CompositeExample.CompositePattern.Interfaces;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Threading.Tasks;

namespace CompositeExample.CompositePattern
{
    public class CompositeNotificationService : INotificationService
    {
        private IEnumerable<INotificationService> _services;

        public CompositeNotificationService(IEnumerable<INotificationService> services)
        {
            this._services = services;
        }
        public void Approve(Order order)
        {
            foreach (var service in _services)
            {
                service.Approve(order);
            }
        }
    }
}
