using System;
using System.Runtime.CompilerServices;
using UnityEngine;

namespace Common
{
    public struct Square : IEquatable<Square>
    {
        public const int VERTEX_COUNT = 4;

        public Vector2 position;
        public Vector2 extents;

        public static readonly Square Zero;
        public static readonly Square One = new Square { extents = Vector2.one };

        public int VertexCount
        {
            [MethodImpl(MethodImplOptions.AggressiveInlining)]
            get { return VERTEX_COUNT; }
        }

        public Vector2 this[int index]
        {
            get
            {
                switch (index)
                {
                    case 0: return position + new Vector2(-extents.x, -extents.y) * 0.5f;
                    case 1: return position + new Vector2(-extents.x, +extents.y) * 0.5f;
                    case 2: return position + new Vector2(+extents.x, +extents.y) * 0.5f;
                    case 3: return position + new Vector2(+extents.x, -extents.y) * 0.5f;
                }
                throw new IndexOutOfRangeException($"Invalid Square index {index}");
            }
        }

        public Vector2[] GetVertices()
        {
            return new Vector2[VERTEX_COUNT] { this[0], this[1], this[2], this[3] };
        }

        public float Area
        {
            [MethodImpl(MethodImplOptions.AggressiveInlining)]
            get { return extents.x * extents.y; }
        }

        [MethodImpl(MethodImplOptions.AggressiveInlining)]
        public bool Equals(Square other)
        {
            return
                Mathx.AreEqual(position, other.position) &&
                Mathx.AreEqual(extents, other.extents);
        }

        [MethodImpl(MethodImplOptions.AggressiveInlining)]
        public override bool Equals(object obj)
        {
            return obj is Square converted && Equals(converted);
        }

        [MethodImpl(MethodImplOptions.AggressiveInlining)]
        public override int GetHashCode()
        {
            return position.GetHashCode() ^ (extents.GetHashCode() << 2);
        }

        [MethodImpl(MethodImplOptions.AggressiveInlining)]
        public override string ToString()
        {
            return string.Format("Square({0}, {1})", position, extents);
        }
    }
}