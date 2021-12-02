using System.Runtime.CompilerServices;

namespace Common.Extensions
{
    public static class ArrayTableExtensions
    {
        [MethodImpl(MethodImplOptions.AggressiveInlining)]
        public static bool IsNull<T>(this T[,] self)
        {
            return self == null;
        }

        [MethodImpl(MethodImplOptions.AggressiveInlining)]
        public static bool IsEmpty<T>(this T[,] self)
        {
            return self.Length == 0;
        }

        [MethodImpl(MethodImplOptions.AggressiveInlining)]
        public static bool IsNullOrEmpty<T>(this T[,] self)
        {
            return self.IsNull() || self.IsEmpty();
        }

        [MethodImpl(MethodImplOptions.AggressiveInlining)]
        public static int GetWidth<T>(this T[,] self)
        {
            return self.GetLength(0);
        }

        [MethodImpl(MethodImplOptions.AggressiveInlining)]
        public static int GetHeight<T>(this T[,] self)
        {
            return self.GetLength(1);
        }

        [MethodImpl(MethodImplOptions.AggressiveInlining)]
        public static int GetLengthSafely<T>(this T[,] self, int dimension)
        {
            return self.IsNull() ? 0 : self.GetLength(dimension);
        }
    }
}
