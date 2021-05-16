using System;
using System.Runtime.CompilerServices;
using UnityEngine;

namespace Common
{
    public struct Cube : IEquatable<Cube>
    {
        public const int VERTEX_COUNT = 8;

        public Vector3 position;
        public Vector3 extents;

        public static readonly Cube Zero;
        public static readonly Cube One = new Cube { extents = Vector3.one };

        public static readonly int[][] Triangles = new int[][]
        {
            new int[] { 4, 5, 1, 4, 1, 0, -1 }, // -x
            new int[] { 3, 2, 6, 3, 6, 7, -1 }, // +x
            new int[] { 4, 0, 3, 4, 3, 7, -1 }, // -y
            new int[] { 1, 5, 6, 1, 6, 2, -1 }, // +y
            new int[] { 0, 1, 2, 0, 2, 3, -1 }, // -z
            new int[] { 7, 6, 5, 7, 5, 4, -1 }  // +z
        };
        
        public int VertexCount
        {
            [MethodImpl(MethodImplOptions.AggressiveInlining)]
            get { return VERTEX_COUNT; }
        }

        public Vector3 this[int index]
        {
            get
            {
                switch (index)
                {
                    case 0: return position + new Vector3(-extents.x, -extents.y, -extents.z) * 0.5f;
                    case 1: return position + new Vector3(-extents.x, +extents.y, -extents.z) * 0.5f;
                    case 2: return position + new Vector3(+extents.x, +extents.y, -extents.z) * 0.5f;
                    case 3: return position + new Vector3(+extents.x, -extents.y, -extents.z) * 0.5f;
                    case 4: return position + new Vector3(-extents.x, -extents.y, +extents.z) * 0.5f;
                    case 5: return position + new Vector3(-extents.x, +extents.y, +extents.z) * 0.5f;
                    case 6: return position + new Vector3(+extents.x, +extents.y, +extents.z) * 0.5f;
                    case 7: return position + new Vector3(+extents.x, -extents.y, +extents.z) * 0.5f;
                }
                throw new IndexOutOfRangeException($"Invalid Cube index {index}");
            }
        }

        public Vector3[] GetVertices()
        {
            return new Vector3[VERTEX_COUNT] { this[0], this[1], this[2], this[3], this[4], this[5], this[6], this[7] };
        }

        public float Area
        {
            [MethodImpl(MethodImplOptions.AggressiveInlining)]
            get { return extents.x * extents.y * 2 + extents.y * extents.z * 2 + extents.z * extents.x * 2; }
        }

        public float Volume
        {
            [MethodImpl(MethodImplOptions.AggressiveInlining)]
            get { return extents.x * extents.y * extents.z; }
        }
        
        [MethodImpl(MethodImplOptions.AggressiveInlining)]
        public bool Equals(Cube other)
        {
            return
                Mathx.AreEqual(position, other.position) &&
                Mathx.AreEqual(extents, other.extents);
        }

        [MethodImpl(MethodImplOptions.AggressiveInlining)]
        public override bool Equals(object obj)
        {
            return obj is Cube converted && Equals(converted);
        }

        [MethodImpl(MethodImplOptions.AggressiveInlining)]
        public override int GetHashCode()
        {
            return position.GetHashCode() ^ (extents.GetHashCode() << 2);
        }

        [MethodImpl(MethodImplOptions.AggressiveInlining)]
        public override string ToString()
        {
            return string.Format("Cube({0}, {1})", position, extents);
        }
    }
}