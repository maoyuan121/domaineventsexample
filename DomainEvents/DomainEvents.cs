using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;

namespace DomainEvents
{
    public static class DomainEvents
    {
        [ThreadStatic] // each thread has its own callbacks
        private static List<Delegate> _actions;

        public static void Register<T>(Action<T> callback) where T : IDomainEvent
        {
            _actions = _actions ?? new List<Delegate>();
            _actions.Add(callback);
        }

        public static void ClearCallbacks()
        {
            _actions = null;
        }



        public static void Raise<T>(T args) where T : IDomainEvent
        {
            if (_actions != null)
            {
                foreach (var action in _actions)
                {
                    if (action is Action<T>)
                    {
                        ((Action<T>)action)(args);
                    }
                }
            }
        }



    }
}
