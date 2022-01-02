using System;
using System.Runtime.CompilerServices;
using UnityEngine;

namespace Common.Mathematics
{
    [Serializable]
    public struct Hexagon : IEquatable<Hexagon>
    {
        public Vector2 centre;
        public float radius;

        public static readonly Hexagon Zero;
        public static readonly Hexagon One = new Hexagon { radius = 1.0f };

        [MethodImpl(MethodImplOptions.AggressiveInlining)]
        public Hexagon(Vector2 centre, float radius)
        {
            this.centre = centre;
            this.radius = radius;
        }

        [MethodImpl(MethodImplOptions.AggressiveInlining)]
        public Hexagon(Hexagon other) :
            this(other.centre, other.radius)
        {
        }

        [MethodImpl(MethodImplOptions.AggressiveInlining)]
        public bool Equals(Hexagon other)
        {
            return (
                Mathx.IsEqual(centre, other.centre) &&
                Mathx.IsEqual(radius, other.radius)
            );
        }

        public override bool Equals(object obj)
        {
            return obj is Hexagon && Equals((Hexagon)obj);
        }

        public override int GetHashCode()
        {
            return (
                centre.GetHashCode() ^
                (radius.GetHashCode() << 2)
            );
        }

        public override string ToString()
        {
            return ToString("F2");
        }

        public string ToString(string format)
        {
            return string.Format("({0}, {1})", centre.ToString(format), radius.ToString(format));
        }
    }
}
