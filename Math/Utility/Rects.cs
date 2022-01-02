using System.Runtime.CompilerServices;
using UnityEngine;

namespace Common.Mathematics
{
    public static class Rects
    {
        public const int VERTEX_COUNT = 4;

        /// <summary> Triangles of a square </summary>
        public static readonly int[] Triangles = new int[]
        {
            0, 1, 2, 0, 2, 3, -1
        };

        /// <summary> Calculates vertices of a square defined by centre 'c' and extents 'e', into array </summary>
        [MethodImpl(MethodImplOptions.AggressiveInlining)]
        public static void Vertices(Vector2[] vs, Vector2 c, Vector2 e)
        {
            e *= 0.5f;
            vs[0] = c + new Vector2(-e.x, -e.y);
            vs[1] = c + new Vector2(-e.x, +e.y);
            vs[2] = c + new Vector2(+e.x, +e.y);
            vs[3] = c + new Vector2(+e.x, -e.y);
        }

        /// <summary> Calculates vertices of a unit square into array </summary>
        [MethodImpl(MethodImplOptions.AggressiveInlining)]
        public static Vector2[] Vertices(Vector2 c, Vector2 e)
        {
            var vs = new Vector2[VERTEX_COUNT];
            Vertices(vs, c, e);
            return vs;
        }

        /// <summary> Calculates area of a rectangle defined by extents 'e' </summary>
        [MethodImpl(MethodImplOptions.AggressiveInlining)]
        public static float Area(Vector2 e)
        {
            return e.x * e.y;
        }
    }
}