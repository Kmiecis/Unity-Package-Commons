using System;
using System.Runtime.CompilerServices;
using UnityEngine;

namespace Common.Mathematics
{
    [Serializable]
    public struct CosEquation
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
            return (Mathf.Cos(((x + dx) * sx) * 0.5f * Mathf.PI) + dy) * sy;
        }

        [MethodImpl(MethodImplOptions.AggressiveInlining)]
        public static float Evaluate(float x, CosEquation f)
        {
            return Evaluate(x, f.dx, f.sx, f.dy, f.sy);
        }

        [MethodImpl(MethodImplOptions.AggressiveInlining)]
        public static CosEquation FromPoints(Vector2 A, Vector2 B)
        {
            throw new NotImplementedException("CosEquation.FromPoints(A, B) not yet implemented");
        }

        public bool Equals(CosEquation other)
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
                obj is CosEquation &&
                Equals((CosEquation)obj)
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
            return string.Format("y = (cos((x + {0}) * {1}) + {2}) * {3}", dx, sx, dy, sy);
        }
    }
}
