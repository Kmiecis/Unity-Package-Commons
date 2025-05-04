using UnityEngine;

namespace Common
{
    public static class UQuaternion
    {
        public static readonly Quaternion NaN = new Quaternion(float.NaN, float.NaN, float.NaN, float.NaN);
        public static readonly Quaternion NegInf = new Quaternion(float.NegativeInfinity, float.NegativeInfinity, float.NegativeInfinity, float.NegativeInfinity);
        public static readonly Quaternion PosInf = new Quaternion(float.PositiveInfinity, float.PositiveInfinity, float.PositiveInfinity, float.PositiveInfinity);
    }
}