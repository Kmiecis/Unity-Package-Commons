using UnityEngine;

namespace Common
{
    public static class LayerMaskExtensions
    {
        public static bool Contains(this LayerMask self, int layer)
        {
            return self == (self | (1 << layer));
        }

        public static int GetLayer(this LayerMask self)
        {
            return (int)Mathf.Log(self.value, 2);
        }
    }
}
