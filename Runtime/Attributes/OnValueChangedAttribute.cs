using UnityEngine;

namespace Common
{
    /// <summary> Invokes 'callback' method on field change. Fallbacks to On{field_name}Changed. </summary>
    public sealed class OnValueChangedAttribute : PropertyAttribute
    {
        public readonly string callback;

        public OnValueChangedAttribute(string callback = null)
        {
            this.callback = callback;
        }
    }
}
