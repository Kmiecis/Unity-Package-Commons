using System.Runtime.CompilerServices;
using UnityEngine;

namespace Common
{
    public static class Squares
    {
        /*_ __ __ __
        1           2
        |           |
        |           |
        |           |
        0__ __ __ __3
        */

        /// <summary> Triangles of a square </summary>
        public static readonly int[] Triangles = new int[]
        {
            0, 1, 2, 0, 2, 3, -1
        };

        /// <summary> Calculates vertices of a square defined by center 'c' and extents 'e' </summary>
        public static Vector2[] Vertices(Vector2 c, Vector2 e)
        {
            return new Vector2[]
            {
                c + new Vector2(-e.x, -e.y) * 0.5f,
                c + new Vector2(-e.x, +e.y) * 0.5f,
                c + new Vector2(+e.x, +e.y) * 0.5f,
                c + new Vector2(+e.x, -e.y) * 0.5f
            };
        }

        /// <summary> Calculates vertices of a square defined by extents 'e' </summary>
        public static Vector2[] Vertices(Vector2 e)
        {
            return new Vector2[]
            {
                new Vector2(-e.x, -e.y) * 0.5f,
                new Vector2(-e.x, +e.y) * 0.5f,
                new Vector2(+e.x, +e.y) * 0.5f,
                new Vector2(+e.x, -e.y) * 0.5f
            };
        }

        /// <summary> Calculates area of a square defined by extents 'e' </summary>
        [MethodImpl(MethodImplOptions.AggressiveInlining)]
        public static float Area(Vector2 e)
        {
            return e.x * e.y;
        }
    }
}