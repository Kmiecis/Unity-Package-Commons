using System;

namespace Common.Pooling
{
    public class DelegatedPool<T> : APool<T>
    {
        private Func<T> _construct;
        private Action<T> _destroy;

        public DelegatedPool(int capacity) :
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
