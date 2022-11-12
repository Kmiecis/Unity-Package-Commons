using Common.Mathematics;
using UnityEngine;

namespace Common.Extensions
{
    public static class CameraExtensions
    {
        public static bool IsInFOV(this Camera self, Vector3 v)
        {
            var sv = self.WorldToViewportPoint(v);

            return (
                sv.x >= 0.0f && sv.x <= 1.0f &&
                sv.y >= 0.0f && sv.y <= 1.0f &&
                sv.z >= self.nearClipPlane && sv.z <= self.farClipPlane
            );
        }

        public static Vector2 GetOrthographicSize(this Camera self)
        {
            var y = 2.0f * self.orthographicSize;
            var x = y * self.aspect;
            return new Vector2(x, y);
        }

        public static Vector2 GetFrustumSize(this Camera self, float distance)
        {
            var y = Mathx.SizeAtDistance(self.fieldOfView, distance);
            var x = y * self.aspect;
            return new Vector2(x, y);
        }
    }
}
