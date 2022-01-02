using System.Runtime.CompilerServices;
using UnityEngine;

namespace Common.Mathematics
{
    public static class Ellipses
    {
        /// <summary> Calculates perimeter of a ellipse defined by width 'w' and height 'h' </summary>
        [MethodImpl(MethodImplOptions.AggressiveInlining)]
        public static float Perimeter(float w, float h)
        {
            w *= 0.5f;
            h *= 0.5f;
            float d = w - h;
            float s = w + h;
            float g = d * d / s * s;
            return Mathf.PI * s * (1 + 3 * g / (10 + Mathf.Sqrt(4 - 3 * g)));
        }

        /// <summary> Calculates radius of an ellipse defined by width 'w' and height 'h' at angle 'a' </summary>
        [MethodImpl(MethodImplOptions.AggressiveInlining)]
        public static float Radius(float w, float h, float a)
        {
            var p = Circles.Point(a);
            return (w * h) / Mathf.Sqrt(w * w * p.x * p.x + h * h * p.y * p.y);
        }

        /// <summary> Calculates radius of an ellipsoid defined by width 'e', height 'f' and depth 'g' at angles 'a' and 'b' </summary>
        [MethodImpl(MethodImplOptions.AggressiveInlining)]
        public static float Radius(float w, float h, float d, float a, float b)
        {
            var p = Spheres.Point(a, b);
            return (w * h * d) / Mathf.Sqrt(w * w * p.x * p.x + h * h * p.y * p.y + d * d * p.z * p.z);
        }
    }
}
