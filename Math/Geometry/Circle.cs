using System;
using System.Runtime.CompilerServices;
using UnityEngine;

namespace Common
{
    public struct Circle : IEquatable<Circle>
    {
        public Vector2 position;
        public float radius;

        public static readonly Circle Zero;
        public static readonly Circle One = new Circle { radius = 1.0f };

        public float Area
        {
            [MethodImpl(MethodImplOptions.AggressiveInlining)]
            get { return Mathf.PI * radius * radius; }
        }

        public float Circumference
        {
            [MethodImpl(MethodImplOptions.AggressiveInlining)]
            get { return 2.0f * Mathf.PI * radius; }
        }

        public float Diameter
        {
            [MethodImpl(MethodImplOptions.AggressiveInlining)]
            get { return 2.0f * radius; }
        }

        [MethodImpl(MethodImplOptions.AggressiveInlining)]
        public float Distance(Vector2 p)
        {
            return Vector2.Distance(position, p) - radius;
        }

        [MethodImpl(MethodImplOptions.AggressiveInlining)]
        public bool Contains(Vector2 p)
        {
            var d = p - position;
            return d.x * d.x + d.y * d.y < radius * radius;
        }

        [MethodImpl(MethodImplOptions.AggressiveInlining)]
        public bool Collides(Circle other)
        {
            var dx = other.position.x - position.x;
            var dy = other.position.y - position.y;
            var sr = radius + other.radius;
            return dx * dx + dy * dy <= sr * sr;
        }

        [MethodImpl(MethodImplOptions.AggressiveInlining)]
        public bool Equals(Circle other)
        {
            return
                Mathx.AreEqual(position, other.position) &&
                Mathx.AreEqual(radius, other.radius);
        }

        [MethodImpl(MethodImplOptions.AggressiveInlining)]
        public override bool Equals(object obj)
        {
            return obj is Circle converted && Equals(converted);
        }

        [MethodImpl(MethodImplOptions.AggressiveInlining)]
        public override int GetHashCode()
        {
            return position.GetHashCode() ^ (radius.GetHashCode() << 2);
        }

        [MethodImpl(MethodImplOptions.AggressiveInlining)]
        public override string ToString()
        {
            return string.Format("Circle({0}, {1})", position, radius);
        }

        [MethodImpl(MethodImplOptions.AggressiveInlining)]
        public static bool TryCreate(Vector2 v0, Vector2 v1, Vector2 v2, out Circle circle)
        {
            circle = Circle.Zero;

            var m1c = new Vector4(v0.x * v0.x + v0.y * v0.y, v1.x * v1.x + v1.y * v1.y, v2.x * v2.x + v2.y * v2.y, 0.0f);
            var m2c = new Vector4(v0.x, v1.x, v2.x, 0.0f);
            var m3c = new Vector4(v0.y, v1.y, v2.y, 0.0f);
            var m4c = new Vector4(1.0f, 1.0f, 1.0f, 0.0f);
            var m5c = new Vector4(0.0f, 0.0f, 0.0f, 1.0f);

            var M11 = new Matrix4x4(m2c, m3c, m4c, m5c);
            var M12 = new Matrix4x4(m1c, m3c, m4c, m5c);
            var M13 = new Matrix4x4(m1c, m2c, m4c, m5c);
            var M14 = new Matrix4x4(m1c, m2c, m3c, m5c);

            var detM11 = M11.determinant;
            var detM12 = M12.determinant;
            var detM13 = M13.determinant;
            var detM14 = M14.determinant;

            if (Mathx.IsZero(detM11))
                return false;

            var x = 0.5f * detM12 / detM11;
            var y = -0.5f * detM13 / detM11;

            circle.position = new Vector2(x, y);
            circle.radius = Mathf.Sqrt(x * x + y * y + detM14 / detM11);

            return true;
        }
    }
}