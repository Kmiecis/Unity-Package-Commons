using UnityEngine;

namespace Common
{
	public static class Vector3Extensions
	{
		public static Vector2 XY(this Vector3 v)
		{
			return new Vector2(v.x, v.y);
		}

		public static Vector2 XZ(this Vector3 v)
		{
			return new Vector2(v.x, v.z);
		}

		public static Vector3 YZ(this Vector3 v)
		{
			return new Vector2(v.y, v.z);
		}
	}
}