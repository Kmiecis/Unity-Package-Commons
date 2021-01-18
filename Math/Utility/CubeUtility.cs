using UnityEngine;

namespace Common
{
	public static class CubeUtility
	{
		public const float CENTER_TO_SIDE = 0.5f;

		public const int VCOUNT = 8;
		public static readonly Vector3[] VERTICES = new Vector3[]
		{
			new Vector3(-CENTER_TO_SIDE, -CENTER_TO_SIDE, -CENTER_TO_SIDE),
			new Vector3(-CENTER_TO_SIDE, +CENTER_TO_SIDE, -CENTER_TO_SIDE),
			new Vector3(+CENTER_TO_SIDE, +CENTER_TO_SIDE, -CENTER_TO_SIDE),
			new Vector3(+CENTER_TO_SIDE, -CENTER_TO_SIDE, -CENTER_TO_SIDE),
			new Vector3(-CENTER_TO_SIDE, -CENTER_TO_SIDE, +CENTER_TO_SIDE),
			new Vector3(-CENTER_TO_SIDE, +CENTER_TO_SIDE, +CENTER_TO_SIDE),
			new Vector3(+CENTER_TO_SIDE, +CENTER_TO_SIDE, +CENTER_TO_SIDE),
			new Vector3(+CENTER_TO_SIDE, -CENTER_TO_SIDE, +CENTER_TO_SIDE)
		};
		
		public const int DCOUNT = 6;
		public static readonly Vector3Int[] DIRECTIONS = new Vector3Int[]
		{
			Vector3Int.back,
			Vector3Int.forward,
			Vector3Int.left,
			Vector3Int.right,
			Vector3Int.down,
			Vector3Int.up
		};

		public static readonly int[][] TRIANGLES = new int[][]
		{
			new int[] { 0, 1, 2, 0, 2, 3, -1 },
			new int[] { 7, 6, 5, 7, 5, 4, -1 },
			new int[] { 4, 5, 1, 4, 1, 0, -1 },
			new int[] { 3, 2, 6, 3, 6, 7, -1 },
			new int[] { 4, 0, 3, 4, 3, 7, -1 },
			new int[] { 1, 5, 6, 1, 6, 2, -1 }
		};

		public enum Direction
		{
			Back,
			Forward,
			Left,
			Right,
			Down,
			Up,
			Count
		}
	}
}