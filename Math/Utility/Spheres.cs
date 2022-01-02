using System.Runtime.CompilerServices;
using UnityEngine;

namespace Common.Mathematics
{
    public static class Spheres
    {
        /// <summary> Calculates area of a sphere with radius 'r' </summary>
        [MethodImpl(MethodImplOptions.AggressiveInlining)]
        public static float Area(float r)
        {
            return 4.0f * Mathf.PI * r * r;
        }

        /// <summary> Calculates whether sphere 'a' with center in 'ac' and radius 'ar' collides with sphere 'b' with center in 'bc' and radius 'br' </summary>
        [MethodImpl(MethodImplOptions.AggressiveInlining)]
        public static bool Collides(Vector3 ac, float ar, Vector3 bc, float br)
        {
            var dx = bc.x - ac.x;
            var dy = bc.y - ac.y;
            var dz = bc.z - ac.z;
            var sumr = ar + br;
            return dx * dx + dy * dy + dz * dz <= sumr * sumr;
        }

        /// <summary> Calculates whether point 'p' is within sphere with center in 'c' and radius 'r' </summary>
        [MethodImpl(MethodImplOptions.AggressiveInlining)]
        public static bool Contains(Vector3 c, float r, Vector3 p)
        {
            var d = p - c;
            return d.x * d.x + d.y * d.y + d.z * d.z < r * r;
        }

        /// <summary> Calculates distance from nearest point of sphere with center in 'c' and radius 'r' to point 'p' </summary>
        [MethodImpl(MethodImplOptions.AggressiveInlining)]
        public static float Distance(Vector3 c, float r, Vector3 p)
        {
            return Vector3.Distance(c, p) - r;
        }

        /// <summary> Calculates normalized point from two angles 'a' and 'b' </summary>
        [MethodImpl(MethodImplOptions.AggressiveInlining)]
        public static Vector3 Point(float a, float b)
        {
            var t = Mathf.Acos(b * (1.0f / Mathf.PI) - 1.0f);
            var x = Mathf.Sin(t) * Mathf.Cos(a);
            var y = Mathf.Sin(t) * Mathf.Sin(a);
            var z = Mathf.Cos(t);
            return new Vector3(x, y, z);
        }

        /// <summary> Attempts to calculate a sphere with center in 'c' and radius 'r' from four points </summary>
        public static bool TryCreate(Vector3 v0, Vector3 v1, Vector3 v2, Vector3 v3, out Vector3 c, out float r)
        {
            c = default;
            r = default;

            var p = new float[4, 4]
            {
                { v0.x, v0.y, v0.z, 1.0f },
                { v1.x, v1.y, v1.z, 1.0f },
                { v2.x, v2.y, v2.z, 1.0f },
                { v3.x, v3.y, v3.z, 1.0f }
            };
            var a = new float[4, 4];

            // Find minor 1, 1.
            for (int i = 0; i < 4; i++)
            {
                a[i, 0] = p[i, 0];
                a[i, 1] = p[i, 1];
                a[i, 2] = p[i, 2];
            }
            float detM11 = Mathx.Determinant(a);

            if (Mathx.IsZero(detM11))
                return false;

            for (int i = 0; i < 4; i++)
            {
                a[i, 0] = p[i, 0] * p[i, 0] + p[i, 1] * p[i, 1] + p[i, 2] * p[i, 2];
            }

            for (int i = 0; i < 4; i++)
            {
                a[i, 1] = p[i, 1];
                a[i, 2] = p[i, 2];
            }
            float detM12 = Mathx.Determinant(a);

            for (int i = 0; i < 4; i++)
            {
                a[i, 1] = p[i, 0];
                a[i, 2] = p[i, 2];
            }
            float detM13 = Mathx.Determinant(a);

            for (int i = 0; i < 4; i++)
            {
                a[i, 1] = p[i, 0];
                a[i, 2] = p[i, 1];
            }
            float detM14 = Mathx.Determinant(a);

            for (int i = 0; i < 4; i++)
            {
                a[i, 1] = p[i, 0];
                a[i, 2] = p[i, 1];
                a[i, 3] = p[i, 2];
            }
            float detM15 = Mathx.Determinant(a);

            c.x = 0.5f * detM12 / detM11;
            c.y = -0.5f * detM13 / detM11;
            c.z = 0.5f * detM14 / detM11;
            r = Mathf.Sqrt(c.x * c.x + c.y * c.y + c.z * c.z - detM15 / detM11);
            return true;
        }

        /// <summary> Calculates volume of a sphere with radius 'r' </summary>
        [MethodImpl(MethodImplOptions.AggressiveInlining)]
        public static float Volume(float r)
        {
            return (4.0f / 3.0f) * Mathf.PI * r * r * r;
        }
    }
}
