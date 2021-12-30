using System;
using System.Runtime.CompilerServices;
using UnityEngine;

namespace Common
{
    [Serializable]
    public struct Cube : IEquatable<Cube>
    {
        public Vector3 c;
        public Vector3 e;

        public static readonly Cube zero;
        public static readonly Cube one = new Cube { e = Vector3.one };

        [MethodImpl(MethodImplOptions.AggressiveInlining)]
        public Cube(Vector3 c, Vector3 e)
        {
            this.c = c;
            this.e = e;
        }

        [MethodImpl(MethodImplOptions.AggressiveInlining)]
        public Cube(Cube o) :
            this(o.c, o.e)
        {
        }

        public bool Equals(Cube other)
        {
            return (
                Mathx.IsEqual(c, other.c) &&
                Mathx.IsEqual(e, other.e)
            );
        }

        public override bool Equals(object obj)
        {
            return obj is Cube && Equals((Cube)obj);
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
            return base.ToString();
        }

        public string ToString(string format)
        {
            return string.Format("({0}, {1})", c.ToString(format), e.ToString(format));
        }
    }
}
