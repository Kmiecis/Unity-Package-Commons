namespace Common
{
    public class IteratingProvider<T> : AProvider<T>
    {
        protected readonly T[] _values;
        protected int _index = -1;

        public IteratingProvider(T[] values)
        {
            _values = values;
        }

        protected T Current
        {
            get => _values[_index];
        }

        public override T Get()
        {
            _index = (_index + 1) % _values.Length;
            return Current;
        }
    }
}
