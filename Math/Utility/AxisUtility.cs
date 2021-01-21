using UnityEngine;

namespace Common
{
	public static class AxisUtility
	{
		public static readonly Vector3Int[] AXES = new Vector3Int[]
		{
			Vector3Int.right,
			Vector3Int.up,
			Vector3Int.forward
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