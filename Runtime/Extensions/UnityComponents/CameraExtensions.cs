using Common.Mathematics;
using UnityEngine;

namespace Common.Extensions
{
    public static class CameraExtensions
    {
        public static bool ContainsScreenPoint(this Camera self, Vector2 v)
        {
            var sv = self.ScreenToViewportPoint(v);
            return (
                sv.x >= 0.0f && sv.x <= 1.0f &&
                sv.y >= 0.0f && sv.y <= 1.0f
            );
        }

        public static bool ContainsWorldPoint(this Camera self, Vector3 v)
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

        public static Vector2 GetNearFrustumSize(this Camera self)
        {
            return self.GetFrustumSize(self.nearClipPlane);
        }

        public static Vector2 GetFarFrustumSize(this Camera self)
        {
            return self.GetFrustumSize(self.farClipPlane);
        }

        public static Ray ScreenCenterToRay(this Camera self)
        {
            var pos = new Vector2(Screen.width * 0.5f, Screen.height * 0.5f);
            return self.ScreenPointToRay(pos);
        }
    }
}
