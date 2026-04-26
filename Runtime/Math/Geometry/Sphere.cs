using System;
using System.Runtime.CompilerServices;
using UnityEngine;

namespace Common.Mathematics
{
    [Serializable]
    public struct Sphere : IEquatable<Sphere>
    {
        public Vector3 center;
        public float radius;

        public static readonly Sphere Zero;
        public static readonly Sphere One = new Sphere { radius = 1.0f };
        public static readonly Sphere Empty = new Sphere { radius = float.MinValue };

        [MethodImpl(MethodImplOptions.AggressiveInlining)]
        public Sphere(Vector3 center, float radius)
        {
            this.center = center;
            this.radius = radius;
        }

        [MethodImpl(MethodImplOptions.AggressiveInlining)]
        public Sphere(Sphere other) :
            this(other.center, other.radius)
        {
        }

        public readonly float Area
        {
            [MethodImpl(MethodImplOptions.AggressiveInlining)]
            get => 4.0f * Mathf.PI * radius * radius;
        }

        public readonly float Volume
        {
            [MethodImpl(MethodImplOptions.AggressiveInlining)]
            get => (4.0f / 3.0f) * Mathf.PI * radius * radius * radius;
        }

        [MethodImpl(MethodImplOptions.AggressiveInlining)]
        public readonly bool Contains(in Vector3 point)
        {
            var delta = point - center;
            return delta.x * delta.x + delta.y * delta.y + delta.z * delta.z < radius * radius;
        }

        [MethodImpl(MethodImplOptions.AggressiveInlining)]
        public readonly float Distance(in Vector3 point)
        {
            return Vector3.Distance(center, point) - radius;
        }

        [MethodImpl(MethodImplOptions.AggressiveInlining)]
        public void Encapsulate(in Vector3 point)
        {
            var delta = point - center;
            var distance = delta.magnitude;

            if (distance <= radius)
                return;

            var newRadius = (radius + distance) * 0.5f;
            var t = (newRadius - radius) / distance;
            center = center + delta * t;
            radius = newRadius;
        }

        [MethodImpl(MethodImplOptions.AggressiveInlining)]
        public void Encapsulate(in Sphere other)
        {
            var delta = other.center - this.center;
            var distance = delta.magnitude;

            if (distance + other.radius <= this.radius)
                return;

            if (distance + this.radius <= other.radius)
            {
                this.center = other.center;
                this.radius = other.radius;
                return;
            }

            var newRadius = (this.radius + distance + other.radius) * 0.5f;
            var t = (newRadius - this.radius) / distance;
            this.center = this.center + delta * t;
            this.radius = newRadius;
        }

        [MethodImpl(MethodImplOptions.AggressiveInlining)]
        public void Validate()
        {
            radius = Mathf.Min(radius, 0.0f);
        }

        [MethodImpl(MethodImplOptions.AggressiveInlining)]
        public static bool operator ==(Sphere left, Sphere right)
        {
            return (
                left.center == right.center &&
                left.radius == right.radius
            );
        }

        [MethodImpl(MethodImplOptions.AggressiveInlining)]
        public static bool operator !=(Sphere left, Sphere right)
        {
            return !(left == right);
        }

        [MethodImpl(MethodImplOptions.AggressiveInlining)]
        public static implicit operator Sphere(Circle circle)
        {
            return new Sphere(circle.center, circle.radius);
        }

        [MethodImpl(MethodImplOptions.AggressiveInlining)]
        public readonly bool Equals(Sphere other)
        {
            return (
                Mathx.IsEqual(this.center, other.center) &&
                Mathx.IsEqual(this.radius, other.radius)
            );
        }

        public readonly override bool Equals(object obj)
        {
            return obj is Sphere other && Equals(other);
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
