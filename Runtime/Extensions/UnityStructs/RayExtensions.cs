using UnityEngine;

namespace Common.Extensions
{
    public static class RayExtensions
    {
        public static float Distance(this Ray self, Vector3 point)
        {
            return Vector3.Cross(self.direction, point - self.origin).magnitude;
        }
    }
}