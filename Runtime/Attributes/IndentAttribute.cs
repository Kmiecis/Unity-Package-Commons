using UnityEngine;

namespace Common
{
    public sealed class IndentAttribute : PropertyAttribute
    {
        public readonly int indent;

        public IndentAttribute(int indent)
        {
            this.indent = indent;
        }
    }
}