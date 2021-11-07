using System;

namespace Common
{
    public struct Property<T>
    {
        private readonly Func<T> _getter;
        private readonly Action<T> _setter;

        public delegate void Alteration(ref T value);

        public Property(Func<T> getter, Action<T> setter)
        {
            _getter = getter;
            _setter = setter;
        }

        public T Value
        {
            get => _getter();
            set => _setter(value);
        }

        public void Alter(Alteration method)
        {
            var value = _getter();
            method(ref value);
            _setter(value);
        }
    }
}
