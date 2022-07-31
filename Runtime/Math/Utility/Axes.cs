using UnityEngine;

namespace Common.Mathematics
{
    public static class Axes
    {
        public static readonly Vector3Int[] Positive3D = new Vector3Int[]
        {
            new Vector3Int(1, 0, 0),
            new Vector3Int(0, 1, 0),
            new Vector3Int(0, 0, 1)
        };

        public static readonly Vector3Int[] Negative3D = new Vector3Int[]
        {
            new Vector3Int(-1, 0, 0),
            new Vector3Int(0, -1, 0),
            new Vector3Int(0, 0, -1)
        };

        public static readonly Vector3Int[] All3D = new Vector3Int[]
        {
            new Vector3Int(-1, 0, 0),
            new Vector3Int(+1, 0, 0),
            new Vector3Int(0, -1, 0),
            new Vector3Int(0, +1, 0),
            new Vector3Int(0, 0, -1),
            new Vector3Int(0, 0, +1)
        };

        public static readonly Vector2Int[] Positive2D = new Vector2Int[]
        {
            new Vector2Int(1, 0),
            new Vector2Int(0, 1)
        };

        public static readonly Vector2Int[] Negative2D = new Vector2Int[]
        {
            new Vector2Int(-1, 0),
            new Vector2Int(0, -1)
        };

        public static readonly Vector2Int[] All2D = new Vector2Int[]
        {
            new Vector2Int(-1, 0),
            new Vector2Int(+1, 0),
            new Vector2Int(0, -1),
            new Vector2Int(0, +1)
        };
    }
}
