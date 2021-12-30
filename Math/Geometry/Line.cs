using System;
using System.Runtime.CompilerServices;
using UnityEngine;

namespace Common
{
    [Serializable]
    public struct Line : IEquatable<Line>
    {
        public Vector3 c;
        public Vector3 d;

        public static readonly Line zero;

        [MethodImpl(MethodImplOptions.AggressiveInlining)]
        public Line(Vector3 c, Vector3 d)
        {
            this.c = c;
            this.d = d;
        }

        [MethodImpl(MethodImplOptions.AggressiveInlining)]
        public Line(Line o) :
            this(o.c, o.d)
        {
        }

        public bool Equals(Line other)
        {
            return (
                Mathx.IsEqual(c, other.c) &&
                Mathx.IsEqual(d, other.d)
            );
        }

        public override bool Equals(object obj)
        {
            return obj is Line && Equals((Line)obj);
        }

        public override int GetHashCode()
        {
            return (
                c.GetHashCode() ^
                (d.GetHashCode() << 2)
            );
        }

        public override string ToString()
        {
            return ToString("F2");
        }

        public string ToString(string format)
        {
            return string.Format("({0}, {1})", c.ToString(format), d.ToString(format));
        }
    }
}
