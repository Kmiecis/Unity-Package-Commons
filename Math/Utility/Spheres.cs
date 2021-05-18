using System.Runtime.CompilerServices;
using UnityEngine;

namespace Common
{
    public static class Spheres
    {
        /// <summary> Calculates diameter of a sphere with radius 'r' </summary>
        [MethodImpl(MethodImplOptions.AggressiveInlining)]
        public static float Diameter(float r)
        {
            return r * 2.0f;
        }

        /// <summary> Calculates area of a sphere with radius 'r' </summary>
        [MethodImpl(MethodImplOptions.AggressiveInlining)]
        public static float Area(float r)
        {
            return 4.0f * Mathf.PI * r * r;
        }

        /// <summary> Calculates volume of a sphere with radius 'r' </summary>
        [MethodImpl(MethodImplOptions.AggressiveInlining)]
        public static float Volume(float r)
        {
            return (4.0f / 3.0f) * Mathf.PI * r * r * r;
        }

        /// <summary> Calculates normalized direction vector from two angles 'a' and 'b' </summary>
        [MethodImpl(MethodImplOptions.AggressiveInlining)]
        public static Vector3 Direction(float a, float b)
        {
            var t = Mathf.Acos(b * Mathx.PI_INV - 1.0f);
            var x = Mathf.Sin(t) * Mathf.Cos(a);
            var y = Mathf.Sin(t) * Mathf.Sin(a);
            var z = Mathf.Cos(t);
            return new Vector3(x, y, z);
        }
    }
}