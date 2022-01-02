namespace Common.Mathematics
{
    public static class Hashes
    {
        public static int ToHashCode(params object[] objects)
        {
            unchecked
            {
                var result = 0;
                for (int i = 0; i < objects.Length; ++i)
                {
                    result = (result * 397) ^ objects[i].GetHashCode();
                }
                return result;
            }
        }
    }
}
