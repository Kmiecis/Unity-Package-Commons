using System.Runtime.CompilerServices;
using UnityEngine;

namespace Common
{
    public static class Ellipses
    {
        /// <summary> Calculates radius of an ellipse defined by width 'e' and height 'f' at angle 'a' </summary>
        [MethodImpl(MethodImplOptions.AggressiveInlining)]
        public static float Radius(float e, float f, float a)
        {
            var f0 = Mathf.Sin(a);
            var f1 = Mathf.Cos(a);
            return (e * f) / Mathf.Sqrt(e * e * f0 * f0 + f * f * f1 * f1);
        }
    }
}