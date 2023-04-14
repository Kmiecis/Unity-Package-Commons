using UnityEngine;

namespace Common
{
    public static class UVector4
    {
        public static readonly Vector4 Max = new Vector4(float.MaxValue, float.MaxValue, float.MaxValue, float.MaxValue);
        public static readonly Vector4 Min = new Vector4(float.MinValue, float.MinValue, float.MinValue, float.MinValue);
        public static readonly Vector4 NaN = new Vector4(float.NaN, float.NaN, float.NaN, float.NaN);
        public static readonly Vector4 NegInf = new Vector4(float.NegativeInfinity, float.NegativeInfinity, float.NegativeInfinity, float.NegativeInfinity);
        public static readonly Vector4 PosInf = new Vector4(float.PositiveInfinity, float.PositiveInfinity, float.PositiveInfinity, float.PositiveInfinity);
    }
}
