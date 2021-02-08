using UnityEngine;

namespace Common
{
	public static class AxisUtility
	{
		public static readonly Vector3Int[] AXES = new Vector3Int[]
		{
			new Vector3Int(1, 0, 0),
			new Vector3Int(0, 1, 0),
			new Vector3Int(0, 0, 1)
		};

		public enum Axes
		{
			Right,
			Up,
			Forward,
			Count
		}
	}
}