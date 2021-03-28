using UnityEngine;

namespace Common
{
    public class MinFieldAttribute : PropertyAttribute
    {
        public readonly float min;

        public MinFieldAttribute(float min)
        {
            this.min = min;
        }
    }
}