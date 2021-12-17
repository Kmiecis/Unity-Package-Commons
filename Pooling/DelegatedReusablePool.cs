using System;

namespace Common.Pooling
{
    public class DelegatedReusablePool<T> : AReusablePool<T>
        where T : IReusable
    {
        private Func<T> _construct;
        private Action<T> _destroy;

        public DelegatedReusablePool(int capacity) :
            base(capacity)
        {
        }

        public Func<T> ConstructAction
        {
            set => _construct = value;
        }

        public Action<T> DestroyAction
        {
            set => _destroy = value;
        }

        public override T Construct()
        {
            if (_construct != null)
                return _construct();
            return default;
        }

        public override void Destroy(T item)
        {
            _destroy?.Invoke(item);
        }
    }
}
