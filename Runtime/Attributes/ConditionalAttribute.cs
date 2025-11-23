using UnityEngine;

namespace Common
{
    public class ConditionalAttribute : PropertyAttribute
    {
        public readonly string conditional;

        public ConditionalAttribute(string conditional)
        {
            this.conditional = conditional;
        }
    }
}