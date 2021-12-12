namespace Common
{
    public class IteratingProvider<T> : AProvider<T>
    {
        protected readonly T[] _values;
        protected int _index;

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
            return _values[(_index++) % _values.Length];
        }
    }
}
