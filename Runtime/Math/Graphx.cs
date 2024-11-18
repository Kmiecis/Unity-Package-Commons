using Common.Extensions;
using System;
using System.Runtime.CompilerServices;
using UnityEngine;

namespace Common.Mathematics
{
    public static class Graphx
    {
        /// <summary>Converts a <see cref="byte"/> to a <see cref="float"/></summary>
        [MethodImpl(MethodImplOptions.AggressiveInlining)]
        public static float ToFloat(byte b)
        {
            return b * 1.0f / byte.MaxValue;
        }

        /// <summary>Converts a <see cref="float"/> to a <see cref="byte"/></summary>
        [MethodImpl(MethodImplOptions.AggressiveInlining)]
        public static byte ToByte(float f)
        {
            return (byte)(f * byte.MaxValue);
        }

        /// <summary>Converts a <see cref="Color"/> to a <see cref="string"/> by componentwise conversion</summary>
        public static string ToString(Color c)
        {
            return (
                ToByte(c.r).ToString("X2") +
                ToByte(c.g).ToString("X2") +
                ToByte(c.b).ToString("X2") +
                ToByte(c.a).ToString("X2")
            );
        }

        /// <summary>Converts a hex <see cref="string"/> to a <see cref="Color"/></summary>
        public static Color ToColor(string s)
        {
            var split = s.Split(2);
            return new Color(
                ToFloat(Convert.ToByte(split[0], 16)),
                ToFloat(Convert.ToByte(split[1], 16)),
                ToFloat(Convert.ToByte(split[2], 16)),
                ToFloat(split.Length == 4 ? Convert.ToByte(split[3], 16) : byte.MaxValue)
            );
        }

        /// <summary>Converts texture normal vector to unity normal vector</summary>
        [MethodImpl(MethodImplOptions.AggressiveInlining)]
        public static Vector3 ToNormal(Color c)
        {
            return (c.XYZ() * 2.0f).Sub(1.0f).XZY();
        }

        /// <summary>Converts unity normal vector to texture normal vector</summary>
        [MethodImpl(MethodImplOptions.AggressiveInlining)]
        public static Color ToNormal(Vector3 v)
        {
            return (v.XZY().Add(1.0f) * 0.5f).RGB();
        }


        [MethodImpl(MethodImplOptions.AggressiveInlining)]
        public static Color MulByAlpha(Color c)
        {
            c.r *= c.a;
            c.g *= c.a;
            c.b *= c.a;
            return c;
        }
        
        /// <summary>Checks whether <see cref="Color"/> has all NaN variables</summary>
        [MethodImpl(MethodImplOptions.AggressiveInlining)]
        public static bool IsNaN(Color c)
        {
            return (
                float.IsNaN(c.r) &&
                float.IsNaN(c.g) &&
                float.IsNaN(c.b) &&
                float.IsNaN(c.a)
            );
        }

        /// <summary>Checks whether <see cref="Color"/> has any NaN variable</summary>
        public static bool HasNaN(Color c)
        {
            return (
                float.IsNaN(c.r) ||
                float.IsNaN(c.g) ||
                float.IsNaN(c.b) ||
                float.IsNaN(c.a)
            );
        }
    }
}
