using UnityEngine;

namespace Common
{
    public static class MarchingSquares
    {
        public const float SIDE_LENGTH = 1.0f;

        public static readonly Vector2[] Vertices = new Vector2[]
        {
            new Vector2(0.0f, 0.0f),
            new Vector2(0.0f, SIDE_LENGTH),
            new Vector2(SIDE_LENGTH, SIDE_LENGTH),
            new Vector2(SIDE_LENGTH, 0.0f),
            new Vector2(0.0f, SIDE_LENGTH * 0.5f),
            new Vector2(SIDE_LENGTH * 0.5f, SIDE_LENGTH),
            new Vector2(SIDE_LENGTH, SIDE_LENGTH * 0.5f),
            new Vector2(SIDE_LENGTH * 0.5f, 0.0f)
        };

        /*
         __ __ 5 __ __
        1             2
        |  2       4  |
        4             6
        |  1       8  |
        0__ __ 7 __ __3
        */

        public static readonly int[][] Triangles = new int[][]
        {
            new int[]{ -1, -1, -1, -1, -1, -1, -1, -1, -1, -1, -1, -1, -1 }, // 0
            new int[]{  0,  4,  7, -1, -1, -1, -1, -1, -1, -1, -1, -1, -1 }, // 1
            new int[]{  1,  5,  4, -1, -1, -1, -1, -1, -1, -1, -1, -1, -1 }, // 2
            new int[]{  0,  1,  5,  0,  5,  7, -1, -1, -1, -1, -1, -1, -1 }, // 3 = 1 + 2
            new int[]{  2,  6,  5, -1, -1, -1, -1, -1, -1, -1, -1, -1, -1 }, // 4
            new int[]{  0,  4,  5,  0,  5,  2,  0,  2,  6,  0,  6,  7, -1 }, // 5 = 1 + 4
            new int[]{  1,  2,  6,  1,  6,  4, -1, -1, -1, -1, -1, -1, -1 }, // 6 = 2 + 4
            new int[]{  0,  1,  2,  0,  2,  6,  0,  6,  7, -1, -1, -1, -1 }, // 7 = 1 + 2 + 4
            new int[]{  3,  7,  6, -1, -1, -1, -1, -1, -1, -1, -1, -1, -1 }, // 8
            new int[]{  3,  0,  4,  3,  4,  6, -1, -1, -1, -1, -1, -1, -1 }, // 9 = 1 + 8
            new int[]{  1,  5,  6,  1,  6,  3,  1,  3,  7,  1,  7,  4, -1 }, // 10 = 2 + 8
            new int[]{  3,  0,  1,  3,  1,  5,  3,  5,  6, -1, -1, -1, -1 }, // 11 = 1 + 2 + 8
            new int[]{  2,  3,  7,  2,  7,  5, -1, -1, -1, -1, -1, -1, -1 }, // 12 = 4 + 8
            new int[]{  2,  3,  0,  2,  0,  4,  2,  4,  5, -1, -1, -1, -1 }, // 13 = 1 + 4 + 8
            new int[]{  1,  2,  3,  1,  3,  7,  1,  7,  4, -1, -1, -1, -1 }, // 14 = 2 + 4 + 8
            new int[]{  0,  1,  2,  0,  2,  3, -1, -1, -1, -1, -1, -1, -1 }  // 15 = 1 + 2 + 4 + 8
        };
        
        public static int GetConfiguration(bool isActive0, bool isActive1, bool isActive2, bool isActive3)
        {
            return
                (isActive0 ? 1 : 0) +
                (isActive1 ? 2 : 0) +
                (isActive2 ? 4 : 0) +
                (isActive3 ? 8 : 0);
        }
    }
}