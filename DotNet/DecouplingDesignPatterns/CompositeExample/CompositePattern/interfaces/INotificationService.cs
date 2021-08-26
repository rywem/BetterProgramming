using System;
using System.Collections.Generic;
using System.Linq;
using System.Threading.Tasks;

namespace CompositeExample.CompositePattern.Interfaces
{
    public interface INotificationService
    {
        void Approve(Order order);
    }
}
