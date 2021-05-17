using System.Runtime.CompilerServices;
using UnityEngine;

namespace Common
{
    public static class Circles
    {
        /// <summary> Calculates diameter of a circle with radius 'r' </summary>
        [MethodImpl(MethodImplOptions.AggressiveInlining)]
        public static float Diameter(float r)
        {
            return r * 2.0f;
        }

        /// <summary> Calculates area of a circle with radius 'r' </summary>
        [MethodImpl(MethodImplOptions.AggressiveInlining)]
        public static float Area(float r)
        {
            return Mathf.PI * r * r;
        }

        /// <summary> Calculates circumference of a circle with radius 'r' </summary>
        [MethodImpl(MethodImplOptions.AggressiveInlining)]
        public static float Circumference(float r)
        {
            return 2.0f * Mathf.PI * r;
        }

        /// <summary> Calculates distance from nearest point of circle with center in 'c' and radius 'r' to point 'p' </summary>
        [MethodImpl(MethodImplOptions.AggressiveInlining)]
        public static float Distance(Vector2 c, float r, Vector2 p)
        {
            return Vector2.Distance(c, p) - r;
        }

        /// <summary> Returns whether circle with center in 'c' and radius 'r' contains point 'p' </summary>
        [MethodImpl(MethodImplOptions.AggressiveInlining)]
        public static bool Contains(Vector2 c, float r, Vector2 p)
        {
            var d = p - c;
            return d.x * d.x + d.y * d.y < r * r;
        }

        /// <summary> Returns whether circle 'a' with center in 'ac' and radius 'ar' collides with circle 'b' with center in 'bc' and radius 'br' </summary>
        [MethodImpl(MethodImplOptions.AggressiveInlining)]
        public static bool Collides(Vector2 ac, float ar, Vector2 bc, float br)
        {
            var dx = bc.x - ac.x;
            var dy = bc.y - ac.y;
            var sr = ar + br;
            return dx * dx + dy * dy <= sr * sr;
        }

        /// <summary> Calculates circle with center in 'c' and radius 'r' from points 'v0', 'v1' and 'v2' </summary>
        [MethodImpl(MethodImplOptions.AggressiveInlining)]
        public static bool TryCreate(Vector2 v0, Vector2 v1, Vector2 v2, out Vector2 c, out float r)
        {
            c = default;
            r = default;

            var m1c = new Vector4(v0.x * v0.x + v0.y * v0.y, v1.x * v1.x + v1.y * v1.y, v2.x * v2.x + v2.y * v2.y, 0.0f);
            var m2c = new Vector4(v0.x, v1.x, v2.x, 0.0f);
            var m3c = new Vector4(v0.y, v1.y, v2.y, 0.0f);
            var m4c = new Vector4(1.0f, 1.0f, 1.0f, 0.0f);
            var m5c = new Vector4(0.0f, 0.0f, 0.0f, 1.0f);

            var M11 = new Matrix4x4(m2c, m3c, m4c, m5c);
            var M12 = new Matrix4x4(m1c, m3c, m4c, m5c);
            var M13 = new Matrix4x4(m1c, m2c, m4c, m5c);
            var M14 = new Matrix4x4(m1c, m2c, m3c, m5c);

            var detM11 = M11.determinant;
            var detM12 = M12.determinant;
            var detM13 = M13.determinant;
            var detM14 = M14.determinant;

            if (Mathx.IsZero(detM11))
                return false;

            var x = 0.5f * detM12 / detM11;
            var y = -0.5f * detM13 / detM11;

            c = new Vector2(x, y);
            r = Mathf.Sqrt(x * x + y * y + detM14 / detM11);
            
            return true;
        }
    }
}