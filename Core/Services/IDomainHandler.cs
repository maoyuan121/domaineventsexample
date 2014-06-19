using Core.Events;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;

namespace Core.Services
{
    public interface IDomainHandler<T> where T : IDomainEvent
    {
        void Handle(T @event);
    }
}
