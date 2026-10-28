using System;
using System.Runtime.CompilerServices;
using UnityEngine;

namespace Common.Mathematics
{
    [Serializable]
    public struct Ellipse : IEquatable<Ellipse>
    {
        public Vector2 centre;
        public Vector2 extents;

        public static readonly Ellipse Zero;

        [MethodImpl(MethodImplOptions.AggressiveInlining)]
        public Ellipse(Vector2 centre, Vector2 extents)
        {
            this.centre = centre;
            this.extents = extents;
        }

        [MethodImpl(MethodImplOptions.AggressiveInlining)]
        public Ellipse(Ellipse other) :
            this(other.centre, other.extents)
        {
        }

        public readonly float Perimeter
        {
            [MethodImpl(MethodImplOptions.AggressiveInlining)]
            get
            {
                var w = extents.x * 0.5f;
                var h = extents.y * 0.5f;
                var d = w - h;
                var s = w + h;
                var g = (d * d) / (s * s);
                return Mathf.PI * s * (1 + 3 * g / (10 + Mathf.Sqrt(4 - 3 * g)));
            }
        }

        [MethodImpl(MethodImplOptions.AggressiveInlining)]
        public readonly float Radius(float angle)
        {
            var w = extents.x * 0.5f;
            var h = extents.y * 0.5f;
            var p = Circles.Point(angle);
            return (w * h) / Mathf.Sqrt(h * h * p.x * p.x + w * w * p.y * p.y);
        }

        [MethodImpl(MethodImplOptions.AggressiveInlining)]
        public bool Equals(Ellipse other)
        {
            return (
                Mathx.IsEqual(centre, other.centre) &&
                Mathx.IsEqual(extents, other.extents)
            );
        }

        public override bool Equals(object obj)
        {
            return obj is Ellipse && Equals((Ellipse)obj);
        }

        public override int GetHashCode()
        {
            return (
                centre.GetHashCode() ^
                (extents.GetHashCode() << 2)
            );
        }

        public override string ToString()
        {
            return ToString("F2");
        }

        public string ToString(string format)
        {
            return string.Format("({0}, {1})", centre.ToString(format), extents.ToString(format));
        }
    }
}
