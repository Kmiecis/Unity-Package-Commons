using UnityEngine;

namespace Common
{
    public sealed class NamedArrayAttribute : PropertyAttribute
    {
        public readonly string[] names;

        public NamedArrayAttribute(params string[] names)
        {
            this.names = names;
        }
    }
}
