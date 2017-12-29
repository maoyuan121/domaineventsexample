using Core.Events;
using Core.Services;
using Ninject;

namespace Survey.FrontEnd.App_Start
{
    /// <summary>
    /// 事件分发器的NInject实现
    /// </summary>
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