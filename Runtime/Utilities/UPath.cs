using Common.Extensions;

namespace Common
{
    public static class UPath
    {
        public static string GetPathTo(string path, string directory)
        {
            if (path.TryIndexOf(directory, out int i))
            {
                return path.Substring(0, i - 1);
            }
            return null;
        }

        public static string GetPathFrom(string path, string directory)
        {
            if (path.TryIndexOf(directory, out int index))
            {
                return path.Substring(index + directory.Length + 1);
            }
            return null;
        }

        public static string GetSubPath(string path, string directory)
        {
            if (path.TryIndexOf(directory, out int i))
            {
                return path.Substring(i);
            }
            return null;
        }

        public static string GetPathWithoutExtension(string path)
        {
            if (path.TryLastIndexOf('.', out int i))
            {
                return path.Substring(0, i);
            }
            return path;
        }
    }
}
