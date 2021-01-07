using System;
using System.Runtime.CompilerServices;
using UnityEngine;

namespace Common
{
	/// <summary> Equation in form of: y = a * x * x + b * x + c </summary>
	[Serializable]
	public struct QuadraticEquation
	{
		public float a, b, c;

		public static readonly QuadraticEquation invalid;

		public QuadraticEquation(float a, float b, float c)
		{
			this.a = a;
			this.b = b;
			this.c = c;
		}

		[MethodImpl(MethodImplOptions.AggressiveInlining)]
		public float Evaluate(float x)
		{
			return Evaluate(x, this);
		}

		[MethodImpl(MethodImplOptions.AggressiveInlining)]
		public static float Evaluate(float x, float a, float b, float c)
		{
			return a * x * x + b * x + c;
		}

		[MethodImpl(MethodImplOptions.AggressiveInlining)]
		public static float Evaluate(float x, QuadraticEquation f)
		{
			return Evaluate(x, f.a, f.b, f.c);
		}

		[MethodImpl(MethodImplOptions.AggressiveInlining)]
		public bool IsValid()
		{
			return !Mathx.IsZero(a) && !Mathx.IsZero(b);
		}

		[MethodImpl(MethodImplOptions.AggressiveInlining)]
		public static QuadraticEquation FromPoints(Vector2 A, Vector2 B, Vector2 C)
		{
			var Ea = new Equation3(A.x * A.x, A.x, 1.0f, A.y);
			var Eb = new Equation3(B.x * B.x, B.x, 1.0f, B.y);
			var Ec = new Equation3(C.x * C.x, C.x, 1.0f, C.y);

			var Eba = (Ea - Eb).WithZeroC();
			var Ecb = (Eb - Ec).WithZeroC();

			if (!Eba.IsValid() || !Ecb.IsValid())
			{
				return invalid;
			}

			var nEba = Eba.WithNormalizedB();
			var a = Ecb.EvaluateA(nEba);
			var b = Ecb.EvaluateB(a);
			var c = Ec.EvaluateC(a, b);

			return new QuadraticEquation(a, b, c);
		}

		[MethodImpl(MethodImplOptions.AggressiveInlining)]
		public bool Equals(QuadraticEquation other)
		{
			return
				Mathx.AreEqual(this.a, other.a) &&
				Mathx.AreEqual(this.b, other.b) &&
				Mathx.AreEqual(this.c, other.c);
		}

		[MethodImpl(MethodImplOptions.AggressiveInlining)]
		public override bool Equals(object obj)
		{
			return obj is QuadraticEquation && Equals((QuadraticEquation)obj);
		}

		[MethodImpl(MethodImplOptions.AggressiveInlining)]
		public override int GetHashCode()
		{
			return a.GetHashCode() ^ b.GetHashCode() ^ c.GetHashCode();
		}

		[MethodImpl(MethodImplOptions.AggressiveInlining)]
		public override string ToString()
		{
			return string.Format("y = {0}x2 + {1}x + {2}", a, b, c);
		}
	}
}
