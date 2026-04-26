using System.Runtime.CompilerServices;
using UnityEngine;

namespace Common.Mathematics
{
    public static class Spheres
    {
        /// <summary> Calculates whether sphere with center in 'ac' and radius 'ar' collides with sphere with center in 'bc' and radius 'br' </summary>
        [MethodImpl(MethodImplOptions.AggressiveInlining)]
        public static bool Collides(Vector3 ac, float ar, Vector3 bc, float br)
        {
            var dx = bc.x - ac.x;
            var dy = bc.y - ac.y;
            var dz = bc.z - ac.z;
            var sumr = ar + br;
            return dx * dx + dy * dy + dz * dz <= sumr * sumr;
        }

        /// <summary> Calculates normalized point from two angles 'a' and 'b' </summary>
        [MethodImpl(MethodImplOptions.AggressiveInlining)]
        public static Vector3 Point(float a, float b)
        {
            Vector3 r;
            var t = Mathf.Acos(b * (1.0f / Mathf.PI) - 1.0f);
            r.x = Mathf.Sin(t) * Mathf.Cos(a);
            r.y = Mathf.Sin(t) * Mathf.Sin(a);
            r.z = Mathf.Cos(t);
            return r;
        }

        /// <summary> Attempts to calculate a sphere with center in 'c' and radius 'r' from four points </summary>
        public static bool TryCreate(Vector3 v0, Vector3 v1, Vector3 v2, Vector3 v3, out Sphere sphere)
        {
            sphere = default;

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

            sphere.center.x = 0.5f * detM12 / detM11;
            sphere.center.y = -0.5f * detM13 / detM11;
            sphere.center.z = 0.5f * detM14 / detM11;
            sphere.radius = Mathf.Sqrt(
                sphere.center.x * sphere.center.x +
                sphere.center.y * sphere.center.y +
                sphere.center.z * sphere.center.z -
                detM15 / detM11
            );
            return true;
        }
    }
}
