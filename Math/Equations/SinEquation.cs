using System;
using System.Runtime.CompilerServices;
using UnityEngine;

namespace Common
{
    [Serializable]
    public struct SinEquation
    {
        public float dx, sx, dy, sy;

        [MethodImpl(MethodImplOptions.AggressiveInlining)]
        public float Evaluate(float x)
        {
            return Evaluate(x, this);
        }

        [MethodImpl(MethodImplOptions.AggressiveInlining)]
        public static float Evaluate(float x, float dx = 0.0f, float sx = 1.0f, float dy = 0.0f, float sy = 1.0f)
        {
            return (Mathf.Sin(((x + dx) * sx) * F) + dy) * sy;
        }

        [MethodImpl(MethodImplOptions.AggressiveInlining)]
        public static float Evaluate(float x, SinEquation f)
        {
            return Evaluate(x, f.dx, f.sx, f.dy, f.sy);
        }

        [MethodImpl(MethodImplOptions.AggressiveInlining)]
        public static SinEquation FromPoints(Vector2 A, Vector2 B)
        {
            throw new NotImplementedException("SinEquation.FromPoints(A, B) not yet implemented");
        }

        [MethodImpl(MethodImplOptions.AggressiveInlining)]
        public bool Equals(SinEquation other)
        {
            return Mathx.AreEqual(this.dx, other.dx) &&
                Mathx.AreEqual(this.sx, other.sx) &&
                Mathx.AreEqual(this.dy, other.dy) &&
                Mathx.AreEqual(this.sy, other.sy);
        }

        [MethodImpl(MethodImplOptions.AggressiveInlining)]
        public override bool Equals(object obj)
        {
            return obj is SinEquation && Equals((SinEquation)obj);
        }

        [MethodImpl(MethodImplOptions.AggressiveInlining)]
        public override int GetHashCode()
        {
            return dx.GetHashCode() ^ sx.GetHashCode() ^ dy.GetHashCode() ^ sy.GetHashCode();
        }

        [MethodImpl(MethodImplOptions.AggressiveInlining)]
        public override string ToString()
        {
            return string.Format("y = (sin((x + {0}) * {1}) + {2}) * {3}", dx, sx, dy, sy);
        }

        private const float F = Mathf.PI * 0.5f;
        private const float RF = 1.0f / F;
    }
}
