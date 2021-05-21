namespace Common
{
    public static class Hashes
    {
        public static int Create(params object[] objs)
        {
            unchecked
            {
                var result = 0;
                for (int i = 0; i < objs.Length; ++i)
                {
                    result = (result * 397) ^ objs[i].GetHashCode();
                }
                return result;
            }
        }
    }
}