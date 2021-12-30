using System;
using System.Runtime.CompilerServices;
using UnityEngine;

namespace Common
{
    [Serializable]
    public struct Hexagon : IEquatable<Hexagon>
    {
        public Vector2 c;
        public float r;

        public static readonly Hexagon zero;
        public static readonly Hexagon one = new Hexagon { r = 1.0f };

        [MethodImpl(MethodImplOptions.AggressiveInlining)]
        public Hexagon(Vector2 c, float r)
        {
            this.c = c;
            this.r = r;
        }

        [MethodImpl(MethodImplOptions.AggressiveInlining)]
        public Hexagon(Hexagon o) :
            this(o.c, o.r)
        {
        }

        public bool Equals(Hexagon other)
        {
            return (
                Mathx.IsEqual(c, other.c) &&
                Mathx.IsEqual(r, other.r)
            );
        }

        public override bool Equals(object obj)
        {
            return obj is Hexagon && Equals((Hexagon)obj);
        }

        public override int GetHashCode()
        {
            return (
                c.GetHashCode() ^
                (r.GetHashCode() << 2)
            );
        }

        public override string ToString()
        {
            return ToString("F2");
        }

        public string ToString(string format)
        {
            return string.Format("({0}, {1})", c.ToString(format), r.ToString(format));
        }
    }
}
