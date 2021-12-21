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

        public static bool ContainsIndices<T>(this T[,,] self, int x, int y, int z)
        {
            return (
                -1 < x && -1 < y && -1 < z &&
                x < self.GetWidth() && y < self.GetHeight() && z < self.GetDepth()
            );
        }
    }
}
