using System;
using System.Runtime.CompilerServices;
using UnityEngine;

namespace Common
{
    [Serializable]
    public struct Circle : IEquatable<Circle>
    {
        public Vector2 c;
        public float r;

        public static readonly Circle zero;
        public static readonly Circle one = new Circle { r = 1.0f };

        [MethodImpl(MethodImplOptions.AggressiveInlining)]
        public Circle(Vector2 c, float r)
        {
            this.c = c;
            this.r = r;
        }

        [MethodImpl(MethodImplOptions.AggressiveInlining)]
        public Circle(Circle o) :
            this(o.c, o.r)
        {
        }

        [MethodImpl(MethodImplOptions.AggressiveInlining)]
        public static explicit operator Circle(Sphere s)
        {
            return new Circle(s.c, s.r);
        }
        
        public bool Equals(Circle other)
        {
            return (
                Mathx.IsEqual(c, other.c) &&
                Mathx.IsEqual(r, other.r)
            );
        }

        public override bool Equals(object obj)
        {
            return obj is Circle && Equals((Circle)obj);
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
