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

        /// <summary> Calculates vertices of a square defined by center 'c', extents 'e' and angle 'a' </summary>
        public static Vector2[] Vertices(Vector2 c, Vector2 e, float a)
        {
            var he = e * 0.5f;
            return new Vector2[]
            {
                c + Mathx.Rotate(new Vector2(-he.x, -he.y), a),
                c + Mathx.Rotate(new Vector2(-he.x, +he.y), a),
                c + Mathx.Rotate(new Vector2(+he.x, +he.y), a),
                c + Mathx.Rotate(new Vector2(+he.x, -he.y), a)
            };
        }

        /// <summary> Calculates vertices of a square defined by center 'c' and extents 'e' </summary>
        public static Vector2[] Vertices(Vector2 c, Vector2 e)
        {
            var he = e * 0.5f;
            return new Vector2[]
            {
                c + new Vector2(-he.x, -he.y),
                c + new Vector2(-he.x, +he.y),
                c + new Vector2(+he.x, +he.y),
                c + new Vector2(+he.x, -he.y)
            };
        }

        /// <summary> Calculates vertices of a square defined by extents 'e' </summary>
        public static Vector2[] Vertices(Vector2 e)
        {
            var he = e * 0.5f;
            return new Vector2[]
            {
                new Vector2(-he.x, -he.y),
                new Vector2(-he.x, +he.y),
                new Vector2(+he.x, +he.y),
                new Vector2(+he.x, -he.y)
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