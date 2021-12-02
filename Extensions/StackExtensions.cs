using System.Collections.Generic;
using System.Runtime.CompilerServices;

namespace Common.Extensions
{
    public static class StackExtensions
    {
        [MethodImpl(MethodImplOptions.AggressiveInlining)]
        public static bool IsNull<T>(this Stack<T> self)
        {
            return self == null;
        }

        [MethodImpl(MethodImplOptions.AggressiveInlining)]
        public static bool IsEmpty<T>(this Stack<T> self)
        {
            return self.Count == 0;
        }

        [MethodImpl(MethodImplOptions.AggressiveInlining)]
        public static bool IsNullOrEmpty<T>(this Stack<T> self)
        {
            return self.IsNull() || self.IsEmpty();
        }
    }
}
