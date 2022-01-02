using System.Runtime.CompilerServices;
using UnityEngine;

namespace Common.Mathematics
{
    public static class Hexagons
    {
        public enum Direction
        {
            NE, E, SE, SW, W, NW, Count
        }

        public const int VERTEX_COUNT = 6;

        public const float INNER_TO_OUTER_RADIUS = 2.0f / Mathx.ROOT_3;
        public const float OUTER_TO_INNER_RADIUS = Mathx.ROOT_3 * 0.5f;

        /// <summary> Triangles of a hexagon </summary>
        public static readonly int[] Triangles = new int[]
        {
            0, 1, 2,
            0, 2, 3,
            0, 3, 4,
            0, 4, 5,
            -1
        };

        public static readonly Vector2Int[] Translations = new Vector2Int[]
        {
            new Vector2Int() { x = +0, y = +1 },
            new Vector2Int() { x = +1, y = +0 },
            new Vector2Int() { x = +0, y = -1 },
            new Vector2Int() { x = -1, y = -1 },
            new Vector2Int() { x = -1, y = +0 },
            new Vector2Int() { x = -1, y = +1 }
        };

        /// <summary> Calculates vertices of a hexagon defined by centre 'c' and circumradius 'r', into array </summary>
        [MethodImpl(MethodImplOptions.AggressiveInlining)]
        public static void Vertices(Vector2[] vs, Vector2 c, float r)
        {
            const float INNER_RADIUS = 0.5f;
            const float OUTER_RADIUS = INNER_RADIUS * INNER_TO_OUTER_RADIUS;

            vs[0] = new Vector2(0.0f, OUTER_RADIUS);
            vs[1] = new Vector2(INNER_RADIUS, OUTER_RADIUS * 0.5f);
            vs[2] = new Vector2(INNER_RADIUS, -OUTER_RADIUS * 0.5f);
            vs[3] = new Vector2(0.0f, -OUTER_RADIUS);
            vs[4] = new Vector2(-INNER_RADIUS, -OUTER_RADIUS * 0.5f);
            vs[5] = new Vector2(-INNER_RADIUS, OUTER_RADIUS * 0.5f);
        }

        /// <summary> Calculates vertices of a hexagon defined by centre 'c' and circumradius 'r' </summary>
        [MethodImpl(MethodImplOptions.AggressiveInlining)]
        public static Vector2[] Vertices(Vector2 c, float r)
        {
            var vs = new Vector2[VERTEX_COUNT];
            Vertices(vs, c, r);
            return vs;
        }
        
        /// <summary> Converts position defined in hex coordinates 'v' of a hexagon defined by circumradius 'r' to world position </summary>
        [MethodImpl(MethodImplOptions.AggressiveInlining)]
        public static Vector2 Convert(Vector2Int v, float r)
        {
            float x = (v.x + Mathf.Abs(v.y % 2) * 0.5f) * 2.0f * r * OUTER_TO_INNER_RADIUS;
            float y = v.y * 1.5f * r;
            return new Vector2(x, y);
        }

        /// <summary> Converts position defined as world position 'v' of a hexagon defined by circumradius 'r' to hex coordinates </summary>
        public static Vector2Int Convert(Vector2 v, float r)
        {
            float x = v.x / (r * OUTER_TO_INNER_RADIUS * 2.0f);
            float y = -x;

            float offset = v.y / (r * 3.0f);
            x -= offset;
            y -= offset;

            int ix = Mathf.RoundToInt(x);
            int iy = Mathf.RoundToInt(y);
            int iz = Mathf.RoundToInt(-x - y);

            if (ix + iy + iz != 0)
            {
                float dx = Mathf.Abs(x - ix);
                float dy = Mathf.Abs(y - iy);
                float dz = Mathf.Abs(-x - y - iz);

                if (dx > dy && dx > dz)
                    ix = -iy - iz;
                else if (dz > dy)
                    iz = -ix - iy;
            }

            return new Vector2Int(ix, iz);
        }
    }
}
