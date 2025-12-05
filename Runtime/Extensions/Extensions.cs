namespace Common
{
    public static class Extensions
    {
        public static T Out<T>(this T self, out T value)
        {
            return value = self;
        }
    }
}