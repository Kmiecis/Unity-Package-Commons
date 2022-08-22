using System.Runtime.CompilerServices;
using UnityEngine;

namespace Common.Mathematics
{
    public static class MarchingSquares
    {
        /*
         __ __ 5 __ __
        1             2
        |  2       4  |
        4             6
        |  1       8  |
        0__ __ 7 __ __3
        */

        public static readonly Vector2[] Vertices = new Vector2[]
        {
            new Vector2(0.0f, 0.0f), // 0
            new Vector2(0.0f, 1.0f), // 1
            new Vector2(1.0f, 1.0f), // 2
            new Vector2(1.0f, 0.0f), // 3
            new Vector2(0.0f, 0.5f), // 4
            new Vector2(0.5f, 1.0f), // 5
            new Vector2(1.0f, 0.5f), // 6
            new Vector2(0.5f, 0.0f)  // 7
        };

        /// <summary> Indices array by configuration </summary>
        public static readonly int[][] Triangles = new int[][]
        {
            new int[]{ },                                       // 0
            new int[]{ 0, 4, 7 },                               // 1
            new int[]{ 1, 5, 4 },                               // 2
            new int[]{ 0, 1, 5, 0, 5, 7 },                      // 3 = 1 + 2
            new int[]{ 2, 6, 5 },                               // 4
            new int[]{ 0, 4, 5, 0, 5, 2, 0, 2, 6, 0, 6, 7 },    // 5 = 1 + 4
            new int[]{ 1, 2, 6, 1, 6, 4 },                      // 6 = 2 + 4
            new int[]{ 0, 1, 2, 0, 2, 6, 0, 6, 7 },             // 7 = 1 + 2 + 4
            new int[]{ 3, 7, 6 },                               // 8
            new int[]{ 3, 0, 4, 3, 4, 6 },                      // 9 = 1 + 8
            new int[]{ 1, 5, 6, 1, 6, 3, 1, 3, 7, 1, 7, 4 },    // 10 = 2 + 8
            new int[]{ 3, 0, 1, 3, 1, 5, 3, 5, 6 },             // 11 = 1 + 2 + 8
            new int[]{ 2, 3, 7, 2, 7, 5 },                      // 12 = 4 + 8
            new int[]{ 2, 3, 0, 2, 0, 4, 2, 4, 5 },             // 13 = 1 + 4 + 8
            new int[]{ 1, 2, 3, 1, 3, 7, 1, 7, 4 },             // 14 = 2 + 4 + 8
            new int[]{ 0, 1, 2, 0, 2, 3 }                       // 15 = 1 + 2 + 4 + 8
        };

        /// <summary> Returns configuration of vertices for a marching square </summary>
        [MethodImpl(MethodImplOptions.AggressiveInlining)]
        public static int GetConfiguration(bool isActive0, bool isActive1, bool isActive2, bool isActive3)
        {
            return (
                (isActive0 ? 1 << 0 : 0) +
                (isActive1 ? 1 << 1 : 0) +
                (isActive2 ? 1 << 2 : 0) +
                (isActive3 ? 1 << 3 : 0)
            );
        }
    }
}
