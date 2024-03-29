﻿using UnityEngine;

namespace Common
{
    public static class UVector2
    {
        public static readonly Vector2 Max = new Vector2(float.MaxValue, float.MaxValue);
        public static readonly Vector2 Min = new Vector2(float.MinValue, float.MinValue);
        public static readonly Vector2 NaN = new Vector2(float.NaN, float.NaN);
        public static readonly Vector2 NegInf = new Vector2(float.NegativeInfinity, float.NegativeInfinity);
        public static readonly Vector2 PosInf = new Vector2(float.PositiveInfinity, float.PositiveInfinity);
    }
}
