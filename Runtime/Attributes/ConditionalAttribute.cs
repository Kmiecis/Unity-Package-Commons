using UnityEngine;

namespace Common
{
    /// <summary> Checks 'conditional' method for field displayability. Fallbacks to Display{field_name}Field. </summary>
    public sealed class ConditionalAttribute : PropertyAttribute
    {
        public readonly string conditional;

        public ConditionalAttribute(string conditional = null)
        {
            this.conditional = conditional;
        }
    }
}