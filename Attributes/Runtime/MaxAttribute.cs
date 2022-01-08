using UnityEngine;

namespace Common
{
    public sealed class MaxAttribute : PropertyAttribute
    {
        public readonly float max;

        public MaxAttribute(float max)
        {
            this.max = max;
        }
    }
}
