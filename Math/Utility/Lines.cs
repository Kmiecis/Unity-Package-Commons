using System.Runtime.CompilerServices;
using UnityEngine;

namespace Common.Mathematics
{
    public static class Lines
    {
        /// <summary> Calculates whether point 'p' is within line between points 'v0' and 'v1' </summary>
        [MethodImpl(MethodImplOptions.AggressiveInlining)]
        public static bool Contains(Vector3 v0, Vector3 v1, Vector3 p)
        {
            float v0v1 = (v1 - v0).sqrMagnitude;
            float v0p = (p - v0).sqrMagnitude;
            float pv1 = (v1 - p).sqrMagnitude;
            return Mathx.IsEqual(v0v1, v0p + pv1);
        }

        /// <summary> Calculates nearest point in line between points 'v0' and 'v1' to point 'p' </summary>
        [MethodImpl(MethodImplOptions.AggressiveInlining)]
        public static Vector3 NearestPoint(Vector3 v0, Vector3 v1, Vector3 p)
        {
            var v0v1 = v1 - v0;
            var v0p = p - v0;

            float f1 = Vector3.Dot(v0p, v0v1);
            if (f1 <= 0.0f)
                return v0;

            float f2 = Vector3.Dot(v0v1, v0v1);
            if (f2 <= f1)
                return v1;

            float t = f1 / f2;

            return v0 + (t * v0v1);
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
            float f = (p.x - v0.x) * (v1.y - v0.y) - (p.y - v0.y) * (v1.x - v0.x);
            return f > 0.0f ? +1 : f < 0.0f ? -1 : 0;
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
    }
}
