using UnityEngine;

namespace Common
{
    public static class Axes2D
    {
        public static readonly Vector2Int[] Positive = new Vector2Int[]
        {
            new Vector2Int(+1, 0),
            new Vector2Int(0, +1)
        };

        public static readonly Vector2Int[] Negative = new Vector2Int[]
        {
            new Vector2Int(-1, 0),
            new Vector2Int(0, -1)
        };

        public static readonly Vector2Int[] Horizontal = new Vector2Int[]
        {
            new Vector2Int(+1, 0),
            new Vector2Int(-1, 0)
        };

        public static readonly Vector2Int[] Vertical = new Vector2Int[]
        {
            new Vector2Int(0, +1),
            new Vector2Int(0, -1)
        };

        public static readonly Vector2Int[] All = new Vector2Int[]
        {
            new Vector2Int(0, +1),
            new Vector2Int(+1, 0),
            new Vector2Int(0, -1),
            new Vector2Int(-1, 0)
        };
    }
}