namespace Common.Extensions
{
    public static class Array3DExtensions
    {
        public static bool IsNull<T>(this T[,,] self)
        {
            return self == null;
        }

        public static bool IsEmpty<T>(this T[,,] self)
        {
            return self.Length == 0;
        }

        public static bool IsNullOrEmpty<T>(this T[,,] self)
        {
            return self.IsNull() || self.IsEmpty();
        }

        public static int GetWidth<T>(this T[,,] self)
        {
            return self.GetLength(0);
        }

        public static int GetHeight<T>(this T[,,] self)
        {
            return self.GetLength(1);
        }

        public static int GetDepth<T>(this T[,,] self)
        {
            return self.GetLength(2);
        }

        public static int GetLengthSafely<T>(this T[,,] self, int dimension)
        {
            return self.IsNull() ? 0 : self.GetLength(dimension);
        }
    }
}
