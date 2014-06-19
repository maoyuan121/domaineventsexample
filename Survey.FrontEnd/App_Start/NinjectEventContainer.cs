using System;
using System.Web.Http.Dependencies;
using Ninject;
using Ninject.Syntax;
using Core;
using Core.Events;
using System.Collections.Generic;
using Core.Services;

namespace Survey.FrontEnd.App_Start
{
    public class NinjectEventContainer : IEventDispatcher
    {
        private readonly IKernel _kernel;

        public NinjectEventContainer(IKernel kernel)
        {
            _kernel = kernel;
        }


        public void Dispatch<TEvent>(TEvent eventToDispatch) where TEvent : IDomainEvent
        {
            foreach (var handler in _kernel.GetAll<IDomainHandler<TEvent>>())
            {
                handler.Handle(eventToDispatch);
            }
        }
    }
}