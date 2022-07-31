using System.Collections.Generic;

namespace Common
{
    public class ReverseComparer<T> : IComparer<T>
    {
        protected readonly IComparer<T> _source;

        public ReverseComparer(IComparer<T> source = null)
        {
            _source = source ?? Comparer<T>.Default;
        }

        public static ReverseComparer<T> Default
        {
            get => new ReverseComparer<T>();
        }

        public int Compare(T x, T y)
        {
            return _source.Compare(x, y) * -1;
        }
    }
}
