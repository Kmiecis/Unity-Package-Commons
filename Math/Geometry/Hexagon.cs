using System;
using System.Runtime.CompilerServices;
using UnityEngine;

namespace Common
{
    public struct Hexagon : IEquatable<Hexagon>
    {
        public enum Direction
        {
            NE, E, SE, SW, W, NW, Count
        }

        public const int VERTEX_COUNT = (int)Direction.Count;

        public Vector2 position;
        public float radius;

        public static readonly Hexagon Zero;
        public static readonly Hexagon One = new Hexagon { radius = 1.0f };

        public int VertexCount
        {
            [MethodImpl(MethodImplOptions.AggressiveInlining)]
            get { return VERTEX_COUNT; }
        }

        public Vector2 this[int index]
        {
            [MethodImpl(MethodImplOptions.AggressiveInlining)]
            get
            {
                var u = (index % VERTEX_COUNT) / (1.0f * VERTEX_COUNT);
                return position + Mathx.Direction(u) * radius;
            }
        }

        [MethodImpl(MethodImplOptions.AggressiveInlining)]
        public bool Equals(Hexagon other)
        {
            return
                Mathx.AreEqual(position, other.position) &&
                Mathx.AreEqual(radius, other.radius);
        }

        [MethodImpl(MethodImplOptions.AggressiveInlining)]
        public override bool Equals(object obj)
        {
            return obj is Hexagon converted && Equals(converted);
        }

        [MethodImpl(MethodImplOptions.AggressiveInlining)]
        public override int GetHashCode()
        {
            return position.GetHashCode() ^ (radius.GetHashCode() << 2);
        }

        [MethodImpl(MethodImplOptions.AggressiveInlining)]
        public override string ToString()
        {
            return string.Format("Hexagon({0}, {1})", position, radius);
        }
    }
}