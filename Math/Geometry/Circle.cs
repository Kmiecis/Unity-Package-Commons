using System;
using System.Runtime.CompilerServices;
using UnityEngine;

namespace Common.Mathematics
{
    [Serializable]
    public struct Circle : IEquatable<Circle>
    {
        public Vector2 centre;
        public float radius;

        public static readonly Circle Zero;
        public static readonly Circle One = new Circle { radius = 1.0f };

        [MethodImpl(MethodImplOptions.AggressiveInlining)]
        public Circle(Vector2 centre, float radius)
        {
            this.centre = centre;
            this.radius = radius;
        }

        [MethodImpl(MethodImplOptions.AggressiveInlining)]
        public Circle(Circle other) :
            this(other.centre, other.radius)
        {
        }

        [MethodImpl(MethodImplOptions.AggressiveInlining)]
        public static explicit operator Circle(Sphere sphere)
        {
            return new Circle(sphere.centre, sphere.radius);
        }

        [MethodImpl(MethodImplOptions.AggressiveInlining)]
        public bool Equals(Circle other)
        {
            return (
                Mathx.IsEqual(centre, other.centre) &&
                Mathx.IsEqual(radius, other.radius)
            );
        }

        public override bool Equals(object obj)
        {
            return obj is Circle && Equals((Circle)obj);
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
