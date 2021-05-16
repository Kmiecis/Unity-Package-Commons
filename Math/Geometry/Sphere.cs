using System;
using System.Runtime.CompilerServices;
using UnityEngine;

namespace Common
{
    public struct Sphere : IEquatable<Sphere>
    {
        public Vector3 position;
        public float radius;

        public static readonly Sphere Zero;
        public static readonly Sphere One = new Sphere { radius = 1.0f };

        public float Area
        {
            [MethodImpl(MethodImplOptions.AggressiveInlining)]
            get { return 4 * Mathf.PI * radius * radius; }
        }
        
        public float Diameter
        {
            [MethodImpl(MethodImplOptions.AggressiveInlining)]
            get { return 2.0f * radius; }
        }

        [MethodImpl(MethodImplOptions.AggressiveInlining)]
        public float Distance(Vector3 p)
        {
            return Vector3.Distance(position, p) - radius;
        }

        [MethodImpl(MethodImplOptions.AggressiveInlining)]
        public bool Contains(Vector3 p)
        {
            var d = p - position;
            return d.x * d.x + d.y * d.y + d.z * d.z < radius * radius;
        }

        [MethodImpl(MethodImplOptions.AggressiveInlining)]
        public bool Collides(Sphere other)
        {
            var dx = other.position.x - position.x;
            var dy = other.position.y - position.y;
            var dz = other.position.z - position.z;
            var sr = radius + other.radius;
            return dx * dx + dy * dy + dz * dz <= sr * sr;
        }

        [MethodImpl(MethodImplOptions.AggressiveInlining)]
        public bool Equals(Sphere other)
        {
            return
                Mathx.AreEqual(position, other.position) &&
                Mathx.AreEqual(radius, other.radius);
        }

        [MethodImpl(MethodImplOptions.AggressiveInlining)]
        public override bool Equals(object obj)
        {
            return obj is Sphere converted && Equals(converted);
        }

        [MethodImpl(MethodImplOptions.AggressiveInlining)]
        public override int GetHashCode()
        {
            return position.GetHashCode() ^ (radius.GetHashCode() << 2);
        }

        [MethodImpl(MethodImplOptions.AggressiveInlining)]
        public override string ToString()
        {
            return string.Format("Sphere({0}, {1})", position, radius);
        }
    }
}