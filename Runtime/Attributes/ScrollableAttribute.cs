using UnityEngine;

namespace Common
{
    public class ScrollableAttribute : PropertyAttribute
    {
        public readonly float delta;

        public ScrollableAttribute(float delta)
        {
            this.delta = delta;
        }
    }
}