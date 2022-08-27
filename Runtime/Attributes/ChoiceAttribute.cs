using UnityEngine;

namespace Common
{
    public sealed class ChoiceAttribute : PropertyAttribute
    {
        public readonly object[] options;

        public ChoiceAttribute(params object[] options)
        {
            this.options = options;
        }
    }
}
