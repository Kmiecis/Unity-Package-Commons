using UnityEngine;

namespace Common
{
    public static class PhysicsUtility
    {
        public static bool RaycastThrough(Ray ray, Collider target, out RaycastHit raycastHit, int passes = 10)
        {
            while (passes > 0 && Physics.Raycast(ray, out raycastHit))
            {
                if (raycastHit.collider == target)
                {
                    return true;
                }
                else
                {
                    ray = new Ray(raycastHit.point + ray.direction * 1e-5f, ray.direction);
                    passes--;
                }
            }

            raycastHit = default;
            return false;
        }
    }
}