using UnityEngine;

namespace CommonEditor
{
    public static class ObjectExtensions
    {
        public static bool IsSelected(this Object self)
        {
            return USelection.IsSelected(self);
        }
    }
}
