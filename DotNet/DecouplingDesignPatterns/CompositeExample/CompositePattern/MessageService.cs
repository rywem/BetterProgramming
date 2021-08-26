using CompositeExample.CompositePattern.Interfaces;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Threading.Tasks;

namespace CompositeExample.CompositePattern
{
    public class MessageService : INotificationService
    {
        public void Approve(Order order)
        {
            Console.WriteLine("MessageService.Approved()!");
        }
    }
}
