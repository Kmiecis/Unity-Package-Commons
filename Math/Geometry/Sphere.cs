using System;
using System.Runtime.CompilerServices;
using UnityEngine;

namespace Common
{
    [Serializable]
    public struct Sphere : IEquatable<Sphere>
    {
        public Vector3 c;
        public float r;

        public static readonly Sphere zero;
        public static readonly Sphere one = new Sphere { r = 1.0f };

        [MethodImpl(MethodImplOptions.AggressiveInlining)]
        public Sphere(Vector3 c, float r)
        {
            this.c = c;
            this.r = r;
        }

        [MethodImpl(MethodImplOptions.AggressiveInlining)]
        public Sphere(Sphere o) :
            this(o.c, o.r)
        {
        }

        [MethodImpl(MethodImplOptions.AggressiveInlining)]
        public static implicit operator Sphere(Circle c)
        {
            return new Sphere(c.c, c.r);
        }

        public bool Equals(Sphere other)
        {
            return (
                Mathx.IsEqual(c, other.c) &&
                Mathx.IsEqual(r, other.r)
            );
        }

        public override bool Equals(object obj)
        {
            return obj is Sphere && Equals((Sphere)obj);
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
