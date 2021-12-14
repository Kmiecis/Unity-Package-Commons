namespace Common.Pooling
{
    public abstract class AReusablePool<T> : APool<T>
        where T : IReusable<T>
    {
        public AReusablePool(int capacity) :
            base(capacity)
        {
        }

        public override void OnBorrow(T item)
        {
            item.OnBorrow(this);
        }

        public override void OnReturn(T item)
        {
            item.OnReturn();
        }
    }
}
