using UnityEngine;

namespace Common
{
    public class SelectableFieldAttribute : PropertyAttribute
    {
        public readonly object[] values;

        public SelectableFieldAttribute(params object[] values)
        {
            this.values = values;
        }
    }
}