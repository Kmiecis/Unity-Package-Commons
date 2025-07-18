using System;
using System.Collections.Generic;

namespace Common.Collections
{
    public class AutoList<T> : List<T>
    {
        private Func<T> _constructor;
        private Action<T> _destructor;

        public Func<T> Constructor
        {
            set => _constructor = value;
        }

        public Action<T> Destructor
        {
            set => _destructor = value;
        }

        public AutoList(Func<T> constructor, Action<T> destructor)
        {
            _constructor = constructor;
            _destructor = destructor;
        }

        public new int Count
        {
            get => base.Count;
            set
            {
                var diff = value - base.Count;
                if (diff == 0)
                    return;

                if (diff > 0)
                {
                    var ts = new T[diff];
                    for (int i = 0; i < diff; ++i)
                        ts[i] = _constructor();
                    base.AddRange(ts);
                }
                else
                {
                    while (diff++ < 0)
                    {
                        var element = this.Last();
                        _destructor(element);
                        this.RemoveLast();
                    }
                }
            }
        }
    }
}