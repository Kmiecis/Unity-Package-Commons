using UnityEngine;

namespace Common
{
    public class UnfoldedAttribute : PropertyAttribute
    {
        public readonly bool labeled;

        public UnfoldedAttribute(bool labeled = true)
        {
            this.labeled = labeled;
        }
    }
}