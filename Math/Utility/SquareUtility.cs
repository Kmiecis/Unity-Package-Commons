using UnityEngine;

namespace Common
{
	public static class SquareUtility
	{
		public const int VCOUNT = 4;
		public const float CENTER_TO_SIDE = 0.5f;
		public const float CENTER_TO_VERTEX = Mathx.ROOT_2 * 0.5f;

		public static readonly Vector2[] Vertices2D = new Vector2[]
		{
			new Vector2(-CENTER_TO_SIDE, -CENTER_TO_SIDE),
			new Vector2(-CENTER_TO_SIDE, +CENTER_TO_SIDE),
			new Vector2(+CENTER_TO_SIDE, +CENTER_TO_SIDE),
			new Vector2(+CENTER_TO_SIDE, -CENTER_TO_SIDE)
		};

		public static readonly Vector3[] Vertices3D = new Vector3[]
		{
			new Vector3(-CENTER_TO_SIDE, 0.0f, -CENTER_TO_SIDE),
			new Vector3(-CENTER_TO_SIDE, 0.0f, +CENTER_TO_SIDE),
			new Vector3(+CENTER_TO_SIDE, 0.0f, +CENTER_TO_SIDE),
			new Vector3(+CENTER_TO_SIDE, 0.0f, -CENTER_TO_SIDE)
		};
	}
}