﻿using System.Runtime.CompilerServices;
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

        /// <summary> Converts coordinates defined by 'v' in space of extents 'e' to a position </summary>
        [MethodImpl(MethodImplOptions.AggressiveInlining)]
        public static Vector3 Convert(Vector3Int v, Vector3 e)
        {
            e.x *= v.x;
            e.y *= v.y;
            e.z *= v.z;
            return e;
        }

        /// <summary> Converts position defined by 'v' in space of extents 'e' to a coordinate </summary>
        [MethodImpl(MethodImplOptions.AggressiveInlining)]
        public static Vector3Int Convert(Vector3 v, Vector3 e)
        {
            Vector3Int r = Vector3Int.zero;
            r.x = Mathf.RoundToInt(v.x / e.x);
            r.y = Mathf.RoundToInt(v.y / e.y);
            r.z = Mathf.RoundToInt(v.z / e.z);
            return r;
        }
    }
}
