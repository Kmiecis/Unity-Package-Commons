using System.Runtime.CompilerServices;
using UnityEngine;

namespace Common.Mathematics
{
    public static class Ellipses
    {
        /// <summary> Calculates radius of an ellipsoid defined by width 'w', height 'h' and depth 'd' at angles 'a' and 'b' </summary>
        [MethodImpl(MethodImplOptions.AggressiveInlining)]
        public static float Radius(float w, float h, float d, float a, float b)
        {
            var p = Spheres.Point(a, b);
            var ww = w * w;
            var hh = h * h;
            var dd = d * d;
            return (w * h * d) / Mathf.Sqrt(hh * dd * p.x * p.x + ww * dd * p.y * p.y + ww * hh * p.z * p.z);
        }
    }
}
