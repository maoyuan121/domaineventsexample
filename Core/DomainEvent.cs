using Core.Events;
using Core.Services;
using System;
using System.Collections.Generic;

namespace Core
{
    /// <summary>
    /// 领域事件静态帮助方法
    /// </summary>
    public static class DomainEvent
    {

        private static List<Delegate> _actions;
        public static IEventDispatcher Dispatcher { get; set; }

        public static void Register<T>(Action<T> callback) where T : IDomainEvent
        {
            _actions = _actions ?? new List<Delegate>();
            _actions.Add(callback);
        }

        public static void ClearCallbacks()
        {
            _actions = null;
        }

        /// <summary>
        /// 触发事件
        /// </summary>
        /// <typeparam name="T"></typeparam>
        /// <param name="event"></param>
        public static void Raise<T>(T @event) where T : IDomainEvent
        {
            if (Dispatcher != null)
            {
                Dispatcher.Dispatch(@event);
            }

            if (_actions != null)
            {
                foreach (var action in _actions)
                {
                    if (action is Action<T>)
                    {
                        ((Action<T>)action)(@event);
                    }
                }                    
            }
        }
    }
}
