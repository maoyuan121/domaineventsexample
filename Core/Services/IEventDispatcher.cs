using Core.Events;

namespace Core.Services
{
    /// <summary>
    /// 事件分发器接口
    /// </summary>
    public interface IEventDispatcher
    {
        void Dispatch<TEvent>(TEvent eventToDispatch) where TEvent : IDomainEvent;
    }
}
