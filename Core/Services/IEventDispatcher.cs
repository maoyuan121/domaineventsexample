using Core.Events;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;

namespace Core.Services
{
    public interface IEventDispatcher
    {
        void Dispatch<TEvent>(TEvent eventToDispatch) where TEvent : IDomainEvent;
    }
}
