using Common.Mathematics;
using UnityEngine;

namespace Common.Extensions
{
    public static class ColliderExtensions
    {
        public static bool Contains(this Collider2D self, Vector2 position)
        {
            return Mathx.IsEqual(self.ClosestPoint(position), position);
        }

        public static bool Contains(this Collider self, Vector3 position)
        {
            return Mathx.IsEqual(self.ClosestPoint(position), position);
        }
    }
}
