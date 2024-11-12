using System.Reflection;

namespace Common
{
    public static class UBinding
    {
        public const BindingFlags PublicInstance = BindingFlags.Public | BindingFlags.Instance;

        public const BindingFlags NonPublicInstance = BindingFlags.NonPublic | BindingFlags.Instance;

        public const BindingFlags PublicStatic = BindingFlags.Public | BindingFlags.Static;

        public const BindingFlags NonPublicStatic = BindingFlags.NonPublic | BindingFlags.Static;

        public const BindingFlags AnyPublic = BindingFlags.Public | BindingFlags.Instance | BindingFlags.Static;

        public const BindingFlags AnyNonPublic = BindingFlags.NonPublic | BindingFlags.Instance | BindingFlags.Static;

        public const BindingFlags AnyInstance = BindingFlags.Public | BindingFlags.NonPublic | BindingFlags.Instance;

        public const BindingFlags AnyStatic = BindingFlags.Public | BindingFlags.NonPublic | BindingFlags.Static;

        public const BindingFlags Anything = BindingFlags.Public | BindingFlags.NonPublic | BindingFlags.Instance | BindingFlags.Static;
    }
}