namespace Common
{
    public static class ArrayTableExtensions
    {
        public static bool IsNull<T>(this T[,] arr)
        {
            return arr == null;
        }

        public static bool IsEmpty<T>(this T[,] arr)
        {
            return arr.Length == 0;
        }

        public static bool IsNullOrEmpty<T>(this T[,] arr)
        {
            return arr.IsNull() || arr.IsEmpty();
        }

        public static int GetLengthSafely<T>(this T[,] arr, int dimension)
        {
            return arr.IsNull() ? 0 : arr.GetLength(dimension);
        }
    }
}