using System;
using System.Runtime.CompilerServices;
using UnityEngine;

namespace Common.Mathematics
{
    [Serializable]
    public struct Sphere : IEquatable<Sphere>
    {
        public Vector3 centre;
        public float radius;

        public static readonly Sphere Zero;
        public static readonly Sphere One = new Sphere { radius = 1.0f };

        [MethodImpl(MethodImplOptions.AggressiveInlining)]
        public Sphere(Vector3 centre, float radius)
        {
            this.centre = centre;
            this.radius = radius;
        }

        [MethodImpl(MethodImplOptions.AggressiveInlining)]
        public Sphere(Sphere other) :
            this(other.centre, other.radius)
        {
        }

        [MethodImpl(MethodImplOptions.AggressiveInlining)]
        public static implicit operator Sphere(Circle c)
        {
            return new Sphere(c.centre, c.radius);
        }

        [MethodImpl(MethodImplOptions.AggressiveInlining)]
        public bool Equals(Sphere other)
        {
            return (
                Mathx.IsEqual(centre, other.centre) &&
                Mathx.IsEqual(radius, other.radius)
            );
        }

        public override bool Equals(object obj)
        {
            return obj is Sphere && Equals((Sphere)obj);
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
