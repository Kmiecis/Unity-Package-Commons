namespace Common.Pooling
{
    public interface IPoolProvider<T>
    {
        IPool<T> GetPool();
    }
}
