using System.Runtime.CompilerServices;
using UnityEngine;

namespace Common.Mathematics
{
    public static class Planes
    {
        /// <summary> Calculates distance of a point 'p' to a plane going through three vertices 'v0', 'v1' and 'v2' </summary>
        [MethodImpl(MethodImplOptions.AggressiveInlining)]
        public static float Distance(Vector3 v0, Vector3 v1, Vector3 v2, Vector3 p)
        {
            var n = Normal(v0, v1, v2);
            var v2dotn = Vector3.Dot(v2, n);
            var pdotn = Vector3.Dot(p, n);
            return pdotn - v2dotn;
        }

        /// <summary> Calculates normal of plane defined by three vertices 'v0', 'v1' and 'v2' </summary>
        [MethodImpl(MethodImplOptions.AggressiveInlining)]
        public static Vector3 Normal(Vector3 v0, Vector3 v1, Vector3 v2)
        {
            var result = Vector3.Cross(v1 - v0, v2 - v1);
            result.Normalize();
            return result;
        }

        /// <summary> Calculates relative positioning of point 'p' to a plane going through three vertices 'v0', 'v1' and 'v2' </summary>
        /// <returns>
        /// +1 - point lies in front of the triangle
        ///  0 - point lies on the triangle
        /// -1 - point lies behind the triangle
        /// </returns>
        [MethodImpl(MethodImplOptions.AggressiveInlining)]
        public static int Positioning(Vector3 v0, Vector3 v1, Vector3 v2, Vector3 p)
        {
            var d = Distance(v0, v1, v2, p);
            return d > 0.0f ? +1 : d < 0.0f ? -1 : 0;
        }

        /// <summary> Checks whether point 'p' is ahead of a plane going through three vertices 'v0', 'v1' and 'v2' </summary>
        [MethodImpl(MethodImplOptions.AggressiveInlining)]
        public static bool IsAhead(Vector3 v0, Vector3 v1, Vector3 v2, Vector3 p)
        {
            return Positioning(v0, v1, v2, p) == +1;
        }

        /// <summary> Checks whether point 'p' is behind a plane going through three vertices 'v0', 'v1' and 'v2' </summary>
        [MethodImpl(MethodImplOptions.AggressiveInlining)]
        public static bool IsBehind(Vector3 v0, Vector3 v1, Vector3 v2, Vector3 p)
        {
            return Positioning(v0, v1, v2, p) == -1;
        }

        /// <summary> Checks whether point 'p' is on a plane going through three vertices 'v0', 'v1' and 'v2' </summary>
        [MethodImpl(MethodImplOptions.AggressiveInlining)]
        public static bool IsOn(Vector3 v0, Vector3 v1, Vector3 v2, Vector3 p)
        {
            return Positioning(v0, v1, v2, p) == 0;
        }

        /// <summary> Calculates point 'p' projection onto plane defined by axes 'ax' and 'ay' </summary>
        [MethodImpl(MethodImplOptions.AggressiveInlining)]
        public static Vector2 ProjectPoint(Vector3 ax, Vector3 ay, Vector3 p)
        {
            var x = Vector3.Dot(ax, p);
            var y = Vector3.Dot(ay, p);
            return new Vector2(x, y);
        }

        /// <summary> Calculates vector 'v' projection onto other vector 'n' </summary>
        [MethodImpl(MethodImplOptions.AggressiveInlining)]
        public static Vector3 ProjectVector(Vector3 v, Vector3 n)
        {
            return n * Vector3.Dot(v, n);
        }

        /// <summary> Calculates vector 'v' projection onto plane defined by normal 'n' </summary>
        [MethodImpl(MethodImplOptions.AggressiveInlining)]
        public static Vector3 ProjectVectorOnPlane(Vector3 v, Vector3 n)
        {
            return v - ProjectVector(v, n);
        }
    }
}