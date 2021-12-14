namespace Common.Pooling
{
    public abstract class AReusable : IReusable<AReusable>
    {
        protected IPool<AReusable> _pool;

        public void Return()
        {
            _pool.Return(this);
        }

        public void OnBorrow(IPool<AReusable> pool)
        {
            _pool = pool;
        }

        public void OnReturn()
        {
            _pool = null;
        }
    }
}
