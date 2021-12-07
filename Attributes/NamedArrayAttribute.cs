using UnityEngine;

namespace Common
{
    public class NamedArrayAttribute : PropertyAttribute
    {
        public readonly string[] names;

        public NamedArrayAttribute(params string[] names)
        {
            this.names = names;
        }
    }
}
