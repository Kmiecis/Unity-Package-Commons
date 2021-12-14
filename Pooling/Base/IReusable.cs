namespace Common.Pooling
{
    public interface IReusable<T>
        where T : IReusable<T>
    {
        void OnBorrow(IPool<T> pool);

        void OnReturn();
    }
}
