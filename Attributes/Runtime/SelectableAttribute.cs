using UnityEngine;

namespace Common
{
    public sealed class SelectableAttribute : PropertyAttribute
    {
        public readonly object[] values;

        public SelectableAttribute(params object[] values)
        {
            this.values = values;
        }
    }
}
