namespace Common.Pooling
{
    public interface IPool<T>
    {
        T Borrow();

        void Return(T item);
    }
}
