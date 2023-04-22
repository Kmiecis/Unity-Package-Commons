using System.Runtime.CompilerServices;
using UnityEngine;

namespace Common.Mathematics
{
    public static class Cubes
    {
        /// <summary> Vertices of a cube </summary>
        public static readonly Vector3[] Vertices = new Vector3[]
        {
            new Vector3(-0.5f, -0.5f, -0.5f),
            new Vector3(-0.5f,  0.5f, -0.5f),
            new Vector3( 0.5f,  0.5f, -0.5f),
            new Vector3( 0.5f, -0.5f, -0.5f),
            new Vector3(-0.5f, -0.5f,  0.5f),
            new Vector3(-0.5f,  0.5f,  0.5f),
            new Vector3( 0.5f,  0.5f,  0.5f),
            new Vector3( 0.5f, -0.5f,  0.5f)
        };

        /// <summary> Triangles of a cube </summary>
        public static readonly int[][] Triangles = new int[][]
        {
            new int[] { 4, 5, 1, 4, 1, 0 }, // -x
            new int[] { 3, 2, 6, 3, 6, 7 }, // +x
            new int[] { 4, 0, 3, 4, 3, 7 }, // -y
            new int[] { 1, 5, 6, 1, 6, 2 }, // +y
            new int[] { 0, 1, 2, 0, 2, 3 }, // -z
            new int[] { 7, 6, 5, 7, 5, 4 }  // +z
        };

        /// <summary> Calculates area of a cube defined by extents 'e' </summary>
        [MethodImpl(MethodImplOptions.AggressiveInlining)]
        public static float Area(Vector3 e)
        {
            return e.x * e.y * 2 + e.y * e.z * 2 + e.z * e.x * 2;
        }

        /// <summary> Calculates volume of a cube defined by extents 'e' </summary>
        [MethodImpl(MethodImplOptions.AggressiveInlining)]
        public static float Volume(Vector3 e)
        {
            return e.x * e.y * e.z;
        }

        /// <summary> Calculates rectangle vertices into 'target' array </summary>
        public static void GetVertices(Vector3[] target, Vector3 position, Vector3 size, Quaternion rotation)
        {
            for (int i = 0; i < Vertices.Length; ++i)
                target[i] = Mathx.Transform(Vertices[i], position, rotation, size);
        }

        /// <summary> Calculates rectangle vertices </summary>
        public static Vector3[] GetVertices(Vector3 position, Vector3 size, Quaternion rotation)
        {
            var vs = new Vector3[Vertices.Length];
            GetVertices(vs, position, size, rotation);
            return vs;
        }

        /// <summary> Converts coordinates defined by 'v' in space of extents 'e' to a position </summary>
        public static Vector3 Convert(Vector3Int v, Vector3 e)
        {
            return new Vector3(
                v.x * e.x,
                v.y * e.y,
                v.z * e.z
            );
        }

        /// <summary> Converts position defined by 'v' in space of extents 'e' to a coordinate </summary>
        public static Vector3Int Convert(Vector3 v, Vector3 e)
        {
            return new Vector3Int(
                Mathf.RoundToInt(v.x / e.x),
                Mathf.RoundToInt(v.y / e.y),
                Mathf.RoundToInt(v.z / e.z)
            );
        }
    }
}
