using UnityEngine;

namespace Common
{
	public static class Vector3IntExtensions
	{
		public static Vector2Int XY(this Vector3Int v)
		{
			return new Vector2Int(v.x, v.y);
		}

		public static Vector2Int XZ(this Vector3Int v)
		{
			return new Vector2Int(v.x, v.z);
		}

		public static Vector2Int YZ(this Vector3Int v)
		{
			return new Vector2Int(v.y, v.z);
		}
	}
}