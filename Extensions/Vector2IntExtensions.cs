using UnityEngine;

namespace Common
{
	public static class Vector2IntExtensions
	{
		public static Vector3Int X_Y(this Vector2Int v)
		{
			return new Vector3Int(v.x, 0, v.y);
		}

		public static Vector3Int XY_(this Vector2Int v)
		{
			return new Vector3Int(v.x, v.y, 0);
		}

		public static Vector3Int _XY(this Vector2Int v)
		{
			return new Vector3Int(0, v.x, v.y);
		}
	}
}