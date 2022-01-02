using UnityEngine;

namespace Common.Mathematics
{
    public static class Vectors2
    {
        public static readonly Vector2 Max = new Vector2(float.MaxValue, float.MaxValue);
        public static readonly Vector2 Min = new Vector2(float.MinValue, float.MinValue);
        public static readonly Vector2 Wide = new Vector2(float.MinValue, float.MaxValue);
        public static readonly Vector2 NaN = new Vector2(float.NaN, float.NaN);
        public static readonly Vector2 NegInf = new Vector2(float.NegativeInfinity, float.NegativeInfinity);
        public static readonly Vector2 PosInf = new Vector2(float.PositiveInfinity, float.PositiveInfinity);
    }
}
