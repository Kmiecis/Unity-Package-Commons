using UnityEngine;

namespace Common
{
    public static class UVector3
    {
        public static readonly Vector3 Max = new Vector3(float.MaxValue, float.MaxValue, float.MaxValue);
        public static readonly Vector3 Min = new Vector3(float.MinValue, float.MinValue, float.MinValue);
        public static readonly Vector3 NaN = new Vector3(float.NaN, float.NaN, float.NaN);
        public static readonly Vector3 NegInf = new Vector3(float.NegativeInfinity, float.NegativeInfinity, float.NegativeInfinity);
        public static readonly Vector3 PosInf = new Vector3(float.PositiveInfinity, float.PositiveInfinity, float.PositiveInfinity);
    }
}
