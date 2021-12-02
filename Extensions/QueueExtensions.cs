using System.Collections.Generic;
using System.Runtime.CompilerServices;

namespace Common.Extensions
{
    public static class QueueExtensions
    {
        [MethodImpl(MethodImplOptions.AggressiveInlining)]
        public static bool IsNull<T>(this Queue<T> self)
        {
            return self == null;
        }

        [MethodImpl(MethodImplOptions.AggressiveInlining)]
        public static bool IsEmpty<T>(this Queue<T> self)
        {
            return self.Count == 0;
        }

        [MethodImpl(MethodImplOptions.AggressiveInlining)]
        public static bool IsNullOrEmpty<T>(this Queue<T> self)
        {
            return self.IsNull() || self.IsEmpty();
        }
    }
}
