using Core.Events;

namespace Core.Services
{
    /// <summary>
    /// 事件处理器接口
    /// </summary>
    /// <typeparam name="T"></typeparam>
    public interface IDomainHandler<T> where T : IDomainEvent
    {
        void Handle(T @event);
    }
}
