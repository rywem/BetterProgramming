using CompositeExample.CompositeDomainEvent.Interfaces;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Threading.Tasks;

namespace CompositeExample.CompositeDomainEvent
{
    public class CompositeEventHandler<TEvent> : IEventHandler<TEvent>
    {
        private readonly IEnumerable<IEventHandler<TEvent>> _handlers;
        public CompositeEventHandler(IEnumerable<IEventHandler<TEvent>> handlers)
        {
            this._handlers = handlers;
        }
        public void Handle(TEvent e)
        {
            foreach (var handler in _handlers)
            {
                handler.Handle(e);
            }
        }
    }
}
