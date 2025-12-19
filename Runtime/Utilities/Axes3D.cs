using UnityEngine;

namespace Common
{
    public static class Axes3D
    {
        public static readonly Vector3Int[] Positive = new Vector3Int[]
        {
            new Vector3Int(+1, 0, 0),
            new Vector3Int(0, +1, 0),
            new Vector3Int(0, 0, +1)
        };

        public static readonly Vector3Int[] Negative = new Vector3Int[]
        {
            new Vector3Int(-1, 0, 0),
            new Vector3Int(0, -1, 0),
            new Vector3Int(0, 0, -1)
        };

        public static readonly Vector3Int[] Horizontal = new Vector3Int[]
        {
            new Vector3Int(+1, 0, 0),
            new Vector3Int(-1, 0, 0)
        };

        public static readonly Vector3Int[] Vertical = new Vector3Int[]
        {
            new Vector3Int(0, +1, 0),
            new Vector3Int(0, -1, 0)
        };

        public static readonly Vector3Int[] Depth = new Vector3Int[]
        {
            new Vector3Int(0, 0, +1),
            new Vector3Int(0, 0, -1)
        };

        public static readonly Vector3Int[] Screen = new Vector3Int[]
        {
            new Vector3Int(0, +1, 0),
            new Vector3Int(+1, 0, 0),
            new Vector3Int(0, -1, 0),
            new Vector3Int(-1, 0, 0)
        };

        public static readonly Vector3Int[] Ground = new Vector3Int[]
        {
            new Vector3Int(0, 0, +1),
            new Vector3Int(+1, 0, 0),
            new Vector3Int(0, 0, -1),
            new Vector3Int(-1, 0, 0)
        };

        public static readonly Vector3Int[] Side = new Vector3Int[]
        {
            new Vector3Int(0, +1, 0),
            new Vector3Int(0, 0, +1),
            new Vector3Int(0, -1, 0),
            new Vector3Int(0, 0, -1)
        };

        public static readonly Vector3Int[] All = new Vector3Int[]
        {
            new Vector3Int(+1, 0, 0),
            new Vector3Int(0, +1, 0),
            new Vector3Int(0, 0, +1),
            new Vector3Int(-1, 0, 0),
            new Vector3Int(0, -1, 0),
            new Vector3Int(0, 0, -1)
        };
    }
}