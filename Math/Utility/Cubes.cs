using System.Runtime.CompilerServices;
using UnityEngine;

namespace Common
{
    public static class Cubes
    {
        public const int VERTEX_COUNT = 8;

        /// <summary> Triangles of a cube </summary>
        public static readonly int[][] Triangles = new int[][]
        {
            new int[] { 4, 5, 1, 4, 1, 0, -1 }, // -x
            new int[] { 3, 2, 6, 3, 6, 7, -1 }, // +x
            new int[] { 4, 0, 3, 4, 3, 7, -1 }, // -y
            new int[] { 1, 5, 6, 1, 6, 2, -1 }, // +y
            new int[] { 0, 1, 2, 0, 2, 3, -1 }, // -z
            new int[] { 7, 6, 5, 7, 5, 4, -1 }  // +z
        };

        /// <summary> Calculates vertices of a unit cube into array </summary>
        [MethodImpl(MethodImplOptions.AggressiveInlining)]
        public static void Vertices(Vector3[] vs)
        {
            vs[0] = new Vector3(-0.5f, -0.5f, -0.5f);
            vs[1] = new Vector3(-0.5f, +0.5f, -0.5f);
            vs[2] = new Vector3(+0.5f, +0.5f, -0.5f);
            vs[3] = new Vector3(+0.5f, -0.5f, -0.5f);
            vs[4] = new Vector3(-0.5f, -0.5f, +0.5f);
            vs[5] = new Vector3(-0.5f, +0.5f, +0.5f);
            vs[6] = new Vector3(+0.5f, +0.5f, +0.5f);
            vs[7] = new Vector3(+0.5f, -0.5f, +0.5f);
        }

        /// <summary> Calculates vertices of a unit cube </summary>
        [MethodImpl(MethodImplOptions.AggressiveInlining)]
        public static Vector3[] Vertices()
        {
            var vs = new Vector3[VERTEX_COUNT];
            Vertices(vs);
            return vs;
        }
        
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
    }
}