using System.Runtime.CompilerServices;
using UnityEngine;

namespace Common.Mathematics
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

        /// <summary> Calculates area of a cube defined by extents 'e' </summary>
        [MethodImpl(MethodImplOptions.AggressiveInlining)]
        public static float Area(Vector3 e)
        {
            return e.x * e.y * 2 + e.y * e.z * 2 + e.z * e.x * 2;
        }

        /// <summary> Calculates vertices of a cube defined by centre 'c' and extents 'e', into array </summary>
        [MethodImpl(MethodImplOptions.AggressiveInlining)]
        public static void Vertices(Vector3[] vs, Vector3 c, Vector3 e)
        {
            e *= 0.5f;
            vs[0] = c + new Vector3(-e.x, -e.y, -e.z);
            vs[1] = c + new Vector3(-e.x, +e.y, -e.z);
            vs[2] = c + new Vector3(+e.x, +e.y, -e.z);
            vs[3] = c + new Vector3(+e.x, -e.y, -e.z);
            vs[4] = c + new Vector3(-e.x, -e.y, +e.z);
            vs[5] = c + new Vector3(-e.x, +e.y, +e.z);
            vs[6] = c + new Vector3(+e.x, +e.y, +e.z);
            vs[7] = c + new Vector3(+e.x, -e.y, +e.z);
        }

        /// <summary> Calculates vertices of a cube defined by centre 'c' and extents 'e' </summary>
        [MethodImpl(MethodImplOptions.AggressiveInlining)]
        public static Vector3[] Vertices(Vector3 c, Vector3 e)
        {
            var vs = new Vector3[VERTEX_COUNT];
            Vertices(vs, c, e);
            return vs;
        }

        /// <summary> Calculates volume of a cube defined by extents 'e' </summary>
        [MethodImpl(MethodImplOptions.AggressiveInlining)]
        public static float Volume(Vector3 e)
        {
            return e.x * e.y * e.z;
        }
    }
}
