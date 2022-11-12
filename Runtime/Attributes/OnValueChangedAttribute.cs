using UnityEngine;

namespace Common
{
    public sealed class OnValueChangedAttribute : PropertyAttribute
    {
        public readonly string callback;

        public OnValueChangedAttribute(string callback)
        {
            this.callback = callback;
        }
    }
}
