using UnityEngine;

namespace Common.Extensions
{
    public static class ColliderExtensions
    {
        public static bool Contains(this Collider self, Vector3 position)
        {
            return Mathx.IsEqual(position, self.ClosestPoint(position));
        }
    }
}
