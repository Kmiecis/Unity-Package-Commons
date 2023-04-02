using System.Runtime.CompilerServices;

namespace Common.Extensions
{
    internal static class OutExtensions
    {
        [MethodImpl(MethodImplOptions.AggressiveInlining)]
        public static bool OutWithTrue<T>(this T self, out T value)
        {
            value = self;
            return true;
        }

        [MethodImpl(MethodImplOptions.AggressiveInlining)]
        public static bool OutWithFalse<T>(this T self, out T value)
        {
            value = self;
            return false;
        }
    }
}
