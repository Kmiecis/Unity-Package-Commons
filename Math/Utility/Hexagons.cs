using System.Runtime.CompilerServices;
using UnityEngine;

namespace Common
{
    public static class Hexagons
    {
        public enum Direction
        {
            NE, E, SE, SW, W, NW, Count
        }

        public const float INNER_TO_OUTER_RADIUS = 2.0f / Mathx.ROOT_3;
        public const float OUTER_TO_INNER_RADIUS = Mathx.ROOT_3 * 0.5f;

        /// <summary> Triangles of a hexagon </summary>
        public static readonly int[] Triangles = new int[]
        {
            0, 1, 2,
            0, 2, 3,
            0, 3, 4,
            0, 4, 5,
            0, 5, 6,
            0, 6, 7,
            -1
        };

        /// <summary> Calculates vertex at index 'i' of a hexagon defined by center 'c' and circumradius 'r' </summary>
        [MethodImpl(MethodImplOptions.AggressiveInlining)]
        public static Vector2 Vertex(Vector2 c, float r, int i)
        {
            const int VERTEX_COUNT = (int)Direction.Count;
            var u = (i % VERTEX_COUNT) / (1.0f * VERTEX_COUNT);
            return c + Mathx.Direction(u) * r;
        }

        /// <summary> Calculates vertex at index 'i' of a hexagon defined by circumradius 'r' </summary>
        [MethodImpl(MethodImplOptions.AggressiveInlining)]
        public static Vector2 Vertex(float r, int i)
        {
            const int VERTEX_COUNT = (int)Direction.Count;
            var u = (i % VERTEX_COUNT) / (1.0f * VERTEX_COUNT);
            return Mathx.Direction(u) * r;
        }

        /// <summary> Calculates vertices of a hexagon defined by center 'c' and circumradius 'r' </summary>
        public static Vector2[] Vertices(Vector2 c, float r)
        {
            return new Vector2[]
            {
                Vertex(c, r, 0),
                Vertex(c, r, 1),
                Vertex(c, r, 2),
                Vertex(c, r, 3),
                Vertex(c, r, 4),
                Vertex(c, r, 5)
            };
        }

        /// <summary> Calculates vertices of a hexagon defined by center 'c' and circumradius 'r' </summary>
        public static Vector2[] Vertices(float r)
        {
            return new Vector2[]
            {
                Vertex(r, 0),
                Vertex(r, 1),
                Vertex(r, 2),
                Vertex(r, 3),
                Vertex(r, 4),
                Vertex(r, 5)
            };
        }
        
        public static readonly Vector2Int[] Translations = new Vector2Int[]
        {
            new Vector2Int() { x = +0, y = +1 },
            new Vector2Int() { x = +1, y = +0 },
            new Vector2Int() { x = +0, y = -1 },
            new Vector2Int() { x = -1, y = -1 },
            new Vector2Int() { x = -1, y = +0 },
            new Vector2Int() { x = -1, y = +1 }
        };

        /// <summary> Convers position defined in hex coordinates 'v' of a hexagon defined by circumradius 'r' to world position </summary>
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