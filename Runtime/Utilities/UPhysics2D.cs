using UnityEngine;

namespace Common.Mathematics
{
    public static class UPhysics2D
    {
        public static bool Raycast(Vector2 origin, Vector2 direction, out RaycastHit2D hitInfo, float distance = float.PositiveInfinity, int layerMask = Physics2D.DefaultRaycastLayers)
        {
            hitInfo = Physics2D.Raycast(origin, direction, distance, layerMask);
            return hitInfo;
        }
    }
}
