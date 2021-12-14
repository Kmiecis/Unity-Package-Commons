using System;

namespace Common
{
    public class RandomProvider<T> : IteratingProvider<T>
    {
        protected readonly Random _random = new Random();

        public RandomProvider(T[] values) :
            base(values)
        {
        }

        public override T Get()
        {
            _index = _random.Next(_values.Length);
            return Current;
        }
    }
}
