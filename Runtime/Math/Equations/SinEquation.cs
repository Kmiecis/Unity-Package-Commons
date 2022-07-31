using System;
using System.Runtime.CompilerServices;
using UnityEngine;

namespace Common.Mathematics
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
            return (Mathf.Sin(((x + dx) * sx) * 0.5f * Mathf.PI) + dy) * sy;
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

        public bool Equals(SinEquation other)
        {
            return (
                Mathx.IsEqual(this.dx, other.dx) &&
                Mathx.IsEqual(this.sx, other.sx) &&
                Mathx.IsEqual(this.dy, other.dy) &&
                Mathx.IsEqual(this.sy, other.sy)
            );
        }

        public override bool Equals(object obj)
        {
            return (
                obj is SinEquation &&
                Equals((SinEquation)obj)
            );
        }

        public override int GetHashCode()
        {
            return (
                dx.GetHashCode() ^
                sx.GetHashCode() ^
                dy.GetHashCode() ^
                sy.GetHashCode()
            );
        }

        public override string ToString()
        {
            return string.Format("y = (sin((x + {0}) * {1}) + {2}) * {3}", dx, sx, dy, sy);
        }
    }
}
