using System;

namespace Common.Pooling
{
    public class DelegatedPool<T> : APool<T>
    {
        private Func<T> _construct;
        private Action<T> _destroy;
        private Action<T> _onBorrow;
        private Action<T> _onReturn;

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

        public Action<T> OnBorrowAction
        {
            set => _onBorrow = value;
        }

        public Action<T> OnReturnAction
        {
            set => _onReturn = value;
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

        public override void OnBorrow(T item)
        {
            _onBorrow?.Invoke(item);
        }

        public override void OnReturn(T item)
        {
            _onReturn?.Invoke(item);
        }
    }
}
