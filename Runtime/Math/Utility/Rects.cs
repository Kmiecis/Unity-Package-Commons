using System.Runtime.CompilerServices;
using UnityEngine;

namespace Common.Mathematics
{
    public static class Rects
    {
        /// <summary> Vertices of a rect </summary>
        public static readonly Vector2[] Vertices = new Vector2[]
        {
            new Vector2(-0.5f, -0.5f),
            new Vector2(-0.5f,  0.5f),
            new Vector2( 0.5f,  0.5f),
            new Vector2( 0.5f, -0.5f)
        };

        /// <summary> Triangles of a rect </summary>
        public static readonly int[] Triangles = new int[]
        {
            0, 1, 2,
            0, 2, 3
        };
        
        /// <summary> Calculates area of a rectangle defined by extents 'e' </summary>
        [MethodImpl(MethodImplOptions.AggressiveInlining)]
        public static float Area(Vector2 e)
        {
            return e.x * e.y;
        }

        /// <summary> Converts coordinates defined by 'v' in space of extents 'e' to a position </summary>
        public static Vector2 Convert(Vector2Int v, Vector2 e)
        {
            return new Vector2(
                v.x * e.x,
                v.y * e.y
            );
        }

        /// <summary> Converts position defined by 'v' in space of extents 'e' to a coordinate </summary>
        public static Vector2Int Convert(Vector2 v, Vector2 e)
        {
            return new Vector2Int(
                Mathf.RoundToInt(v.x / e.x),
                Mathf.RoundToInt(v.y / e.y)
            );
        }
    }
}
