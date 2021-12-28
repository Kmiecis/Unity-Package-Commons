using System.Runtime.CompilerServices;
using UnityEngine;

namespace Common
{
    public static class Segments
    {
        /// <summary> Calculates whether segment of points 'v0' and 'v1' contains point 'p' </summary>
        [MethodImpl(MethodImplOptions.AggressiveInlining)]
        public static bool Contains(Vector3 v0, Vector3 v1, Vector3 p)
        {
            float dv0v1 = (v1 - v0).sqrMagnitude;
            float dv0p = (p - v0).sqrMagnitude;
            float dpv1 = (v1 - p).sqrMagnitude;
            return Mathx.IsEqual(dv0v1, dv0p + dpv1);
        }

        /// <summary> Calculates nearest point on segment of points 'v0' and 'v1' to point 'p' </summary>
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

        /// <summary> Calculates square distance from segment of points 'v0' and 'v1' to point 'p' </summary>
        [MethodImpl(MethodImplOptions.AggressiveInlining)]
        public static float SqrDistance(Vector3 v0, Vector3 v1, Vector3 p)
        {
            return (p - NearestPoint(v0, v1, p)).sqrMagnitude;
        }
    }
}
