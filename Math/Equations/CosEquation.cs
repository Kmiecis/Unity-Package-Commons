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
			return (Mathf.Cos(((x + dx) * sx) * F) + dy) * sy;
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

		[MethodImpl(MethodImplOptions.AggressiveInlining)]
		public bool Equals(CosEquation other)
		{
			return Mathx.AreEqual(this.dx, other.dx) &&
				Mathx.AreEqual(this.sx, other.sx) &&
				Mathx.AreEqual(this.dy, other.dy) &&
				Mathx.AreEqual(this.sy, other.sy);
		}

		[MethodImpl(MethodImplOptions.AggressiveInlining)]
		public override bool Equals(object obj)
		{
			return obj is CosEquation && Equals((CosEquation)obj);
		}

		[MethodImpl(MethodImplOptions.AggressiveInlining)]
		public override int GetHashCode()
		{
			return dx.GetHashCode() ^ sx.GetHashCode() ^ dy.GetHashCode() ^ sy.GetHashCode();
		}

		[MethodImpl(MethodImplOptions.AggressiveInlining)]
		public override string ToString()
		{
			return string.Format("y = (cos((x + {0}) * {1}) + {2}) * {3}", dx, sx, dy, sy);
		}

		private const float F = Mathf.PI * 0.5f;
		private const float RF = 1.0f / F;
	}
}
