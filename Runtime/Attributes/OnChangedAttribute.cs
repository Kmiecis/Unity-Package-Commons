using UnityEngine;

namespace Common
{
    /// <summary> Invokes 'callback' method on field change. Fallbacks to On{field_name}Changed. </summary>
    public sealed class OnChangedAttribute : PropertyAttribute
    {
        public readonly string callback;

        public OnChangedAttribute(string callback = null)
        {
            this.callback = callback;
        }
    }
}
