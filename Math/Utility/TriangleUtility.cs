using System.Runtime.CompilerServices;
using UnityEngine;

namespace Common
{
	public static class TriangleUtility
	{
		/// <summary> Calculates area of a triangle defined by three vertices 'v0', 'v1' and 'v2' </summary>
		[MethodImpl(MethodImplOptions.AggressiveInlining)]
		public static float Area(Vector2 v0, Vector2 v1, Vector2 v2)
		{
			return 0.5f * (-v1.y * v0.x + v2.y * (v0.x - v1.x) + v2.x * (v1.y - v0.y) + v1.x * v0.y);
		}

		/// <summary> Calculates perimeter of a triangle defined by three vertices 'v0', 'v1' and 'v2' </summary>
		[MethodImpl(MethodImplOptions.AggressiveInlining)]
		public static float Perimeter(Vector2 v0, Vector2 v1, Vector2 v2)
		{
			return Vector2.Distance(v1, v0) + Vector2.Distance(v2, v1) + Vector2.Distance(v0, v2); ;
		}

		/// <summary> Returns whether triangle defined by three vertices 'v0', 'v1' and 'v2' contains point 'p' </summary>
		[MethodImpl(MethodImplOptions.AggressiveInlining)]
		public static bool Contains(Vector2 v0, Vector2 v1, Vector2 v2, Vector2 p)
		{
			var s = v0.y * v2.x - v0.x * v2.y + (v2.y - v0.y) * p.x + (v0.x - v2.x) * p.y;
			var t = v0.x * v1.y - v0.y * v1.x + (v0.y - v1.y) * p.x + (v1.x - v0.x) * p.y;

			if ((s < 0) != (t < 0))
				return false;

			var A = -v1.y * v2.x + v0.y * (v2.x - v1.x) + v0.x * (v1.y - v2.y) + v1.x * v2.y;

			return A < 0 ?
					(s <= 0 && s + t >= A) :
					(s >= 0 && s + t <= A);
		}

		/// <summary> Calculates weights of a point 'p' on a triangle defined by three vertices 'v0', 'v1' and 'v2' </summary>
		[MethodImpl(MethodImplOptions.AggressiveInlining)]
		public static Vector3 Weights(Vector2 v0, Vector2 v1, Vector2 v2, Vector2 p)
		{
			var a = v1 - v0;
			var b = v2 - v0;
			var c = p - v0;

			var d = a.x * b.y - b.x * a.y;

			var v = (c.x * b.y - b.x * c.y) / d;
			var w = (a.x * c.y - c.x * a.y) / d;
			var u = 1.0f - v - w;

			return new Vector3(v, w, u);
		}

		/// <summary> Calculates weights of a point 'p' on a triangle defined by three vertices 'v0', 'v1' and 'v2' </summary>
		[MethodImpl(MethodImplOptions.AggressiveInlining)]
		public static Vector3 Weights(Vector3 v0, Vector3 v1, Vector3 v2, Vector3 p)
		{
			var a = v1 - v0;
			var b = v2 - v0;
			var c = p - v0;

			var d00 = Vector3.Dot(a, a);
			var d01 = Vector3.Dot(a, b);
			var d11 = Vector3.Dot(b, b);
			var d20 = Vector3.Dot(c, a);
			var d21 = Vector3.Dot(c, b);
			var d = d00 * d11 - d01 * d01;

			var v = (d11 * d20 - d01 * d21) / d;
			var w = (d00 * d21 - d01 * d20) / d;
			var u = 1.0f - v - w;

			return new Vector3(v, w, u);
		}
	}
}