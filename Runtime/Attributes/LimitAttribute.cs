using UnityEngine;

namespace Common
{
    public sealed class LimitAttribute : PropertyAttribute
    {
        public readonly float min;
        public readonly float max;

        public LimitAttribute(float min = float.MinValue, float max = float.MaxValue)
        {
            this.min = min;
            this.max = max;
        }
    }
}
