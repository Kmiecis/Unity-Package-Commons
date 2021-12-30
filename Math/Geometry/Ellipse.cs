using System;
using System.Runtime.CompilerServices;
using UnityEngine;

namespace Common
{
    [Serializable]
    public struct Ellipse : IEquatable<Ellipse>
    {
        public Vector2 c;
        public Vector2 e;

        public static readonly Ellipse zero;

        [MethodImpl(MethodImplOptions.AggressiveInlining)]
        public Ellipse(Vector2 c, Vector2 e)
        {
            this.c = c;
            this.e = e;
        }

        [MethodImpl(MethodImplOptions.AggressiveInlining)]
        public Ellipse(Ellipse o) :
            this(o.c, o.e)
        {
        }

        public bool Equals(Ellipse other)
        {
            return (
                Mathx.IsEqual(c, other.c) &&
                Mathx.IsEqual(e, other.e)
            );
        }

        public override bool Equals(object obj)
        {
            return obj is Ellipse && Equals((Ellipse)obj);
        }

        public override int GetHashCode()
        {
            return (
                c.GetHashCode() ^
                (e.GetHashCode() << 2)
            );
        }

        public override string ToString()
        {
            return ToString("F2");
        }

        public string ToString(string format)
        {
            return string.Format("({0}, {1})", c.ToString(format), e.ToString(format));
        }
    }
}
