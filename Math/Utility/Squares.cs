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

        /// <summary> Calculates vertices of a unit square into array </summary>
        [MethodImpl(MethodImplOptions.AggressiveInlining)]
        public static void Vertices(Vector2[] vs)
        {
            vs[0] = new Vector2(-0.5f, -0.5f);
            vs[1] = new Vector2(-0.5f, +0.5f);
            vs[2] = new Vector2(+0.5f, +0.5f);
            vs[3] = new Vector2(+0.5f, -0.5f);
        }

        /// <summary> Calculates vertices of a unit square into array </summary>
        [MethodImpl(MethodImplOptions.AggressiveInlining)]
        public static Vector2[] Vertices()
        {
            var vs = new Vector2[4];
            Vertices(vs);
            return vs;
        }
        
        /// <summary> Calculates area of a square defined by extents 'e' </summary>
        [MethodImpl(MethodImplOptions.AggressiveInlining)]
        public static float Area(Vector2 e)
        {
            return e.x * e.y;
        }
    }
}