using UnityEngine;

namespace Common
{
    public static class LayerMaskExtensions
    {
        public static bool Contains(this LayerMask self, int layer)
        {
            return self == (self | (1 << layer));
        }
    }
}
