﻿using System.Runtime.CompilerServices;
using UnityEngine;

namespace Common.Mathematics
{
    public static class Cubes
    {
        /// <summary> Vertices of a cube </summary>
        public static readonly Vector3[] Vertices = new Vector3[]
        {
            new Vector3(0.0f, 0.0f, 0.0f),
            new Vector3(0.0f, 1.0f, 0.0f),
            new Vector3(1.0f, 1.0f, 0.0f),
            new Vector3(1.0f, 0.0f, 0.0f),
            new Vector3(0.0f, 0.0f, 1.0f),
            new Vector3(0.0f, 1.0f, 1.0f),
            new Vector3(1.0f, 1.0f, 1.0f),
            new Vector3(1.0f, 0.0f, 1.0f)
        };

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
    }
}
