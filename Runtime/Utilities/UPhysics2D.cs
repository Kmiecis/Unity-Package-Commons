using System;
using UnityEngine;

namespace Common
{
    public static class UPhysics2D
    {
        public static int RaycastDistanceComparer(RaycastHit2D left, RaycastHit2D right)
        {
            return Math.Sign(left.distance - right.distance);
        }

        public static bool Raycast(Vector2 origin, Vector2 direction, out RaycastHit2D hitInfo, float distance = float.PositiveInfinity, int layerMask = Physics2D.DefaultRaycastLayers)
        {
            hitInfo = Physics2D.Raycast(origin, direction, distance, layerMask);
            return hitInfo;
        }

        public static bool RaycastIgnoreCollision(Vector2 origin, Vector2 direction, out RaycastHit2D hitInfo, Collider2D collider, float distance = float.PositiveInfinity, int layerMask = Physics2D.DefaultRaycastLayers)
        {
            var hits = Physics2D.RaycastAll(origin, direction, distance, layerMask);

            if (hits.Length == 0)
            {
                hitInfo = default;
                return false;
            }

            Array.Sort(hits, RaycastDistanceComparer);

            var hit = hits[0];
            if (ReferenceEquals(hit.collider, collider))
            {
                if (hits.Length > 1)
                {
                    hitInfo = hits[1];
                    return true;
                }

                hitInfo = default;
                return false;
            }

            hitInfo = hit;
            return true;
        }
    }
}
