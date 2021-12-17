namespace Common.Pooling
{
    public abstract class AReusable : IReusable
    {
        public abstract void OnBorrow();

        public abstract void OnReturn();
    }
}
