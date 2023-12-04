using System;
using UnityEngine;

namespace Common
{
    public static class UPhysics
    {
        public static int RaycastDistanceComparer(RaycastHit left, RaycastHit right)
        {
            return Math.Sign(left.distance - right.distance);
        }

        public static bool RaycastIgnoreCollision(Vector3 origin, Vector3 direction, out RaycastHit hitInfo, Collider collider, float distance = float.PositiveInfinity, int layerMask = Physics.DefaultRaycastLayers)
        {
            var hits = Physics.RaycastAll(origin, direction, distance, layerMask);

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
