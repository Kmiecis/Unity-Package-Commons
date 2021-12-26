using Common.Extensions;

namespace Common
{
    public static class Arrays
    {
        public static T[] New<T>(int length)
        {
            return new T[length];
        }

        public static T[][] New<T>(int width, int height)
        {
            return new T[width][].Populate(() => new T[height]);
        }

        public static T[][][] New<T>(int width, int height, int depth)
        {
            return new T[width][][].Populate(() => new T[height][].Populate(() => new T[depth]));
        }
    }
}
