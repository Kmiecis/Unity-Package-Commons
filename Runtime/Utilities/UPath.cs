﻿using System.Collections.Generic;
using System.IO;

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
            if (path.TryIndexOf(directory, out int i))
            {
                return path.Substring(i + directory.Length + 1);
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

        public static string RemoveExtension(string path)
        {
            if (path.TryLastIndexOf('.', out int i))
            {
                return path.Substring(0, i);
            }
            return path;
        }

        public static IEnumerable<string> Split(string path)
        {
            var subpaths = path.Split(Path.DirectorySeparatorChar, Path.AltDirectorySeparatorChar, Path.VolumeSeparatorChar);

            foreach (var subpath in subpaths)
            {
                if (!subpath.IsNullOrEmpty())
                {
                    yield return subpath;
                }
            }
        }
    }
}
