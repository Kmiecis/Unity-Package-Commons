using System.Runtime.CompilerServices;
using UnityEngine;

namespace Common
{
    public static class Planes
    {
        /// <summary> Projects 3D point 'p' to plane in 2D defined by two axes 'ax' and 'ay' </summary>
        [MethodImpl(MethodImplOptions.AggressiveInlining)]
        public static Vector2 Project(Vector3 p, Vector3 ax, Vector3 ay)
        {
            var x = Vector3.Dot(ax, p);
            var y = Vector3.Dot(ay, p);
            return new Vector2(x, y);
        }
    }
}