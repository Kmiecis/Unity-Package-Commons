using System.Runtime.CompilerServices;
using UnityEngine;

namespace Common.Mathematics
{
    public static class Circles
    {
        /// <summary> Calculates area of a circle with radius 'r' </summary>
        [MethodImpl(MethodImplOptions.AggressiveInlining)]
        public static float Area(float r)
        {
            return Mathf.PI * r * r;
        }

        /// <summary> Calculates whether circle 'a' with center in 'ac' and radius 'ar' collides with circle 'b' with center in 'bc' and radius 'br' </summary>
        [MethodImpl(MethodImplOptions.AggressiveInlining)]
        public static bool Collides(Vector2 ac, float ar, Vector2 bc, float br)
        {
            var dx = bc.x - ac.x;
            var dy = bc.y - ac.y;
            var sr = ar + br;
            return dx * dx + dy * dy <= sr * sr;
        }

        /// <summary> Calculates whether point 'p' is within circle with center in 'c' and radius 'r' </summary>
        [MethodImpl(MethodImplOptions.AggressiveInlining)]
        public static bool Contains(Vector2 c, float r, Vector2 p)
        {
            var d = p - c;
            return d.x * d.x + d.y * d.y < r * r;
        }

        /// <summary> Calculates distance from nearest point of circle with center in 'c' and radius 'r' to point 'p' </summary>
        [MethodImpl(MethodImplOptions.AggressiveInlining)]
        public static float Distance(Vector2 c, float r, Vector2 p)
        {
            return Vector2.Distance(c, p) - r;
        }

        /// <summary> Calculates perimeter of a circle with radius 'r' </summary>
        [MethodImpl(MethodImplOptions.AggressiveInlining)]
        public static float Perimeter(float r)
        {
            return 2.0f * Mathf.PI * r;
        }

        /// <summary> Calculates normalized point on circle from an angle 'a' </summary>
        [MethodImpl(MethodImplOptions.AggressiveInlining)]
        public static Vector2 Point(float a)
        {
            var x = Mathf.Cos(a);
            var y = Mathf.Sin(a);
            return new Vector2(x, y);
        }

        /// <summary> Attempts to calculate circle with center in 'c' and radius 'r' from three points </summary>
        public static bool TryCreate(Vector2 v0, Vector2 v1, Vector2 v2, out Vector2 c, out float r)
        {
            c = default;
            r = default;

            var c1 = new Vector4(v0.x * v0.x + v0.y * v0.y, v1.x * v1.x + v1.y * v1.y, v2.x * v2.x + v2.y * v2.y, 0.0f);
            var c2 = new Vector4(v0.x, v1.x, v2.x, 0.0f);
            var c3 = new Vector4(v0.y, v1.y, v2.y, 0.0f);
            var c4 = new Vector4(1.0f, 1.0f, 1.0f, 0.0f);
            var c5 = new Vector4(0.0f, 0.0f, 0.0f, 1.0f);

            var M11 = new Matrix4x4(c2, c3, c4, c5);
            var M12 = new Matrix4x4(c1, c3, c4, c5);
            var M13 = new Matrix4x4(c1, c2, c4, c5);
            var M14 = new Matrix4x4(c1, c2, c3, c5);

            var m11 = M11.determinant;
            var m12 = M12.determinant;
            var m13 = M13.determinant;
            var m14 = M14.determinant;

            if (Mathx.IsZero(m11))
                return false;

            c.x = 0.5f * m12 / m11;
            c.y = -0.5f * m13 / m11;
            r = Mathf.Sqrt(c.x * c.x + c.y * c.y + m14 / m11);
            return true;
        }
    }
}
