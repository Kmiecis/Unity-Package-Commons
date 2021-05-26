using System.Runtime.CompilerServices;
using UnityEngine;

namespace Common
{
    public static class Lines
    {
        /// <summary> Calculates square distance from line of points 'v0' and 'v1' to point 'p' </summary>
        [MethodImpl(MethodImplOptions.AggressiveInlining)]
        public static float SqrDistance(Vector3 v0, Vector3 v1, Vector3 p)
        {
            var v0v1 = v1 - v0;
            v0v1.Normalize();
            var v0p = p - v0;
            float t = Vector3.Dot(v0p, v0v1);
            var c = v0 + t * v0v1;
            return (p - c).sqrMagnitude;
        }

        /// <summary> Calculates relative positioning of point 'p' to line through points 'v0' and 'v1' </summary>
        /// <returns>
        /// +1 - point lies above the line
        ///  0 - point lies on the line
        /// -1 - point lies below the line
        /// </returns>
        [MethodImpl(MethodImplOptions.AggressiveInlining)]
        public static int Positioning(Vector2 v0, Vector2 v1, Vector2 p)
        {
            float v = (p.x - v0.x) * (v1.y - v0.y) - (p.y - v0.y) * (v1.x - v0.x);
            return v > 0.0f ? +1 : v < 0.0f ? -1 : 0;
        }

        /// <summary> Checks whether point 'p' is above line through points 'v0' and 'v1' </summary>
        [MethodImpl(MethodImplOptions.AggressiveInlining)]
        public static bool IsAbove(Vector2 v0, Vector2 v1, Vector2 p)
        {
            return Positioning(v0, v1, p) == +1;
        }

        /// <summary> Checks whether point 'p' is below line through points 'v0' and 'v1' </summary>
        [MethodImpl(MethodImplOptions.AggressiveInlining)]
        public static bool IsBelow(Vector2 v0, Vector2 v1, Vector2 p)
        {
            return Positioning(v0, v1, p) == -1;
        }

        /// <summary> Checks whether point 'p' is on line through points 'v0' and 'v1' </summary>
        [MethodImpl(MethodImplOptions.AggressiveInlining)]
        public static bool IsOn(Vector2 v0, Vector2 v1, Vector2 p)
        {
            return Positioning(v0, v1, p) == 0;
        }

        /// <summary> Calculates whether line of points 'v0' and 'v1' contains point 'p' </summary>
        [MethodImpl(MethodImplOptions.AggressiveInlining)]
        public static bool Contains(Vector3 v0, Vector3 v1, Vector3 p)
        {
            float dv0v1 = (v1 - v0).sqrMagnitude;
            float dv0p = (p - v0).sqrMagnitude;
            float dpv1 = (v1 - p).sqrMagnitude;
            return Mathx.IsEqual(dv0v1, dv0p + dpv1);
        }
    }
}