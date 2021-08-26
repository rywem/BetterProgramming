using CompositeExample.CompositeDomainEvent.Approved.Interfaces;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Threading.Tasks;

namespace CompositeExample.CompositeDomainEvent.Approved
{
    public class MessageService : IMessageService
    {
        public void SendMessage(OrderApproved e)
        {
            Console.WriteLine("MessageService.SendMessage()");
        }
    }
}
