using System;
using System.Runtime.CompilerServices;
using UnityEngine;

namespace Common.Mathematics
{
    [Serializable]
    public struct Circle : IEquatable<Circle>
    {
        public Vector2 center;
        public float radius;

        public static readonly Circle Zero;
        public static readonly Circle One = new Circle { radius = 1.0f };
        public static readonly Circle Empty = new Circle { radius = float.MinValue };

        [MethodImpl(MethodImplOptions.AggressiveInlining)]
        public Circle(Vector2 center, float radius)
        {
            this.center = center;
            this.radius = radius;
        }

        [MethodImpl(MethodImplOptions.AggressiveInlining)]
        public Circle(Circle other) :
            this(other.center, other.radius)
        {
        }

        public readonly float Area
        {
            [MethodImpl(MethodImplOptions.AggressiveInlining)]
            get => Mathf.PI * radius * radius;
        }

        public readonly float Perimeter
        {
            [MethodImpl(MethodImplOptions.AggressiveInlining)]
            get => 2.0f * Mathf.PI * radius;
        }

        [MethodImpl(MethodImplOptions.AggressiveInlining)]
        public readonly bool Contains(in Vector2 point)
        {
            var d = point - center;
            return d.x * d.x + d.y * d.y < radius * radius;
        }

        [MethodImpl(MethodImplOptions.AggressiveInlining)]
        public readonly float Distance(in Vector2 point)
        {
            return Vector2.Distance(center, point) - radius;
        }

        [MethodImpl(MethodImplOptions.AggressiveInlining)]
        public void Validate()
        {
            radius = Mathf.Min(radius, 0.0f);
        }

        [MethodImpl(MethodImplOptions.AggressiveInlining)]
        public static bool operator ==(Circle left, Circle right)
        {
            return (
                left.center == right.center &&
                left.radius == right.radius
            );
        }

        [MethodImpl(MethodImplOptions.AggressiveInlining)]
        public static bool operator !=(Circle left, Circle right)
        {
            return !(left == right);
        }

        [MethodImpl(MethodImplOptions.AggressiveInlining)]
        public static explicit operator Circle(Sphere sphere)
        {
            return new Circle(sphere.center, sphere.radius);
        }

        [MethodImpl(MethodImplOptions.AggressiveInlining)]
        public readonly bool Equals(Circle other)
        {
            return (
                Mathx.IsEqual(this.center, other.center) &&
                Mathx.IsEqual(this.radius, other.radius)
            );
        }

        public readonly override bool Equals(object obj)
        {
            return obj is Circle other && Equals(other);
        }

        public readonly override int GetHashCode()
        {
            return (
                center.GetHashCode() ^
                (radius.GetHashCode() << 2)
            );
        }

        public readonly override string ToString()
        {
            return ToString("F2");
        }
        
        public readonly string ToString(string format)
        {
            return string.Format("({0}, {1})", center.ToString(format), radius.ToString(format));
        }
    }
}
