using UnityEngine;

namespace Common
{
    public class SearchComponentAttribute : PropertyAttribute
    {
    }

    public class SearchComponentInChildrenAttribute : PropertyAttribute
    {
        public bool includeInactive;

        public SearchComponentInChildrenAttribute(bool includeInactive = false)
        {
            this.includeInactive = includeInactive;
        }
    }

    public class SearchComponentInParentAttribute : PropertyAttribute
    {
        public bool includeInactive;

        public SearchComponentInParentAttribute(bool includeInactive = false)
        {
            this.includeInactive = includeInactive;
        }
    }
}
