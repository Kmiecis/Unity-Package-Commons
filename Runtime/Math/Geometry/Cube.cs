using Common.Extensions;
using System;
using System.Runtime.CompilerServices;
using UnityEngine;

namespace Common.Mathematics
{
    [Serializable]
    public struct Cube : IEquatable<Cube>
    {
        public Vector3 origin;
        public Vector3 extents;

        public static readonly Cube Zero;
        public static readonly Cube One = new Cube { extents = Vector3.one };

        [MethodImpl(MethodImplOptions.AggressiveInlining)]
        public Cube(Vector3 origin, Vector3 extents)
        {
            this.origin = origin;
            this.extents = extents;
        }

        [MethodImpl(MethodImplOptions.AggressiveInlining)]
        public Cube(Cube other) :
            this(other.origin, other.extents)
        {
        }

        public Vector3 Centre
        {
            [MethodImpl(MethodImplOptions.AggressiveInlining)]
            get => origin.Add(extents.Mul(0.5f));
        }

        [MethodImpl(MethodImplOptions.AggressiveInlining)]
        public bool Equals(Cube other)
        {
            return (
                Mathx.IsEqual(origin, other.origin) &&
                Mathx.IsEqual(extents, other.extents)
            );
        }

        public override bool Equals(object obj)
        {
            return obj is Cube && Equals((Cube)obj);
        }

        public override int GetHashCode()
        {
            return (
                origin.GetHashCode() ^
                (extents.GetHashCode() << 2)
            );
        }

        public override string ToString()
        {
            return base.ToString();
        }

        public string ToString(string format)
        {
            return string.Format("({0}, {1})", origin.ToString(format), extents.ToString(format));
        }
    }
}
