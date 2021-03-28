using UnityEngine;

namespace Common
{
    public static class CartesianUtility
    {
        public static readonly Vector2Int[] Axes2D = new Vector2Int[]
        {
            new Vector2Int(1, 0),
            new Vector2Int(0, 1)
        };

        public static readonly Vector3Int[] Axes3D = new Vector3Int[]
        {
            new Vector3Int(1, 0, 0),
            new Vector3Int(0, 1, 0),
            new Vector3Int(0, 0, 1)
        };

        public static readonly Vector2Int[] Directions2D = new Vector2Int[]
        {
            new Vector2Int(-1, 0),
            new Vector2Int(0, +1),
            new Vector2Int(+1, 0),
            new Vector2Int(0, -1)
        };

        public static readonly Vector3Int[] Directions3D = new Vector3Int[]
        {
            new Vector3Int(-1, 0, 0),
            new Vector3Int(+1, 0, 0),
            new Vector3Int(0, -1, 0),
            new Vector3Int(0, +1, 0),
            new Vector3Int(0, 0, -1),
            new Vector3Int(0, 0, +1)
        };
    }
}