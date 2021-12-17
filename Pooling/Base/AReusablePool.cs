namespace Common.Pooling
{
    public abstract class AReusablePool<T> : APool<T>
        where T : IReusable
    {
        public AReusablePool(int capacity) :
            base(capacity)
        {
        }

        public override void OnBorrow(T item)
        {
            item.OnBorrow();
        }

        public override void OnReturn(T item)
        {
            item.OnReturn();
        }
    }
}
