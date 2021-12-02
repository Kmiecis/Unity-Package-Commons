using System.Collections.Generic;
using System.Runtime.CompilerServices;

namespace Common.Extensions
{
    public static class HashSetExtensions
    {
        [MethodImpl(MethodImplOptions.AggressiveInlining)]
        public static bool IsNull<T>(this HashSet<T> self)
        {
            return self == null;
        }

        [MethodImpl(MethodImplOptions.AggressiveInlining)]
        public static bool IsEmpty<T>(this HashSet<T> self)
        {
            return self.Count == 0;
        }

        [MethodImpl(MethodImplOptions.AggressiveInlining)]
        public static bool IsNullOrEmpty<T>(this HashSet<T> self)
        {
            return self.IsNull() || self.IsEmpty();
        }
    }
}
