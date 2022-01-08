using System.Runtime.CompilerServices;
using UnityEngine;

namespace Common.Mathematics
{
    public static class Rects
    {
        /// <summary> Vertices of a rect </summary>
        public static Vector2[] Vertices = new Vector2[]
        {
            new Vector2(0.0f, 0.0f),
            new Vector2(0.0f, 1.0f),
            new Vector2(1.0f, 1.0f),
            new Vector2(1.0f, 0.0f)
        };

        /// <summary> Triangles of a rect </summary>
        public static readonly int[] Triangles = new int[]
        {
            0, 1, 2, 0, 2, 3, -1
        };
        
        /// <summary> Calculates area of a rectangle defined by extents 'e' </summary>
        [MethodImpl(MethodImplOptions.AggressiveInlining)]
        public static float Area(Vector2 e)
        {
            return e.x * e.y;
        }

        /// <summary> Calculates rectangle vertices into 'target' array </summary>
        public static void GetVertices(Vector2[] target, Vector2 position, Vector2 size, float angle)
        {
            for (int i = 0; i < Vertices.Length; ++i)
                target[i] = Mathx.Transform(Vertices[i], position, angle, size);
        }

        /// <summary> Calculates rectangle vertices into 'target' array </summary>
        public static void GetVertices(Vector3[] target, Vector3 position, Vector2 size, Quaternion rotation)
        {
            for (int i = 0; i < Vertices.Length; ++i)
                target[i] = Mathx.Transform(Vertices[i], position, rotation, size);
        }
    }
}
