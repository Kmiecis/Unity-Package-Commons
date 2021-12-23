using Common.Extensions;
using System;
using System.Runtime.CompilerServices;
using UnityEngine;

namespace Common
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

        /// <summary>Converts a <see cref="Color"/> to a <see cref="Vector3"/> by componentwise conversion</summary>
        [MethodImpl(MethodImplOptions.AggressiveInlining)]
        public static Vector3 ToVector3(Color c)
        {
            return new Vector3(c.r, c.g, c.b);
        }

        /// <summary>Converts a <see cref="Color"/> to a <see cref="Vector4"/> by componentwise conversion</summary>
        [MethodImpl(MethodImplOptions.AggressiveInlining)]
        public static Vector4 ToVector4(Color c)
        {
            return new Vector4(c.r, c.g, c.b, c.a);
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

        /// <summary>Converts a <see cref="Vector3"/> to a <see cref="Color"/> by componentwise conversion</summary>
        [MethodImpl(MethodImplOptions.AggressiveInlining)]
        public static Color ToColor(Vector3 v)
        {
            return new Color(v.x, v.y, v.z);
        }

        /// <summary>Converts a <see cref="Vector3"/> to a <see cref="Color"/> by componentwise conversion</summary>
        [MethodImpl(MethodImplOptions.AggressiveInlining)]
        public static Color ToColor(Vector3 v, float a)
        {
            return new Color(v.x, v.y, v.z, a);
        }

        /// <summary>Converts a <see cref="Vector4"/> to a <see cref="Color"/> by componentwise conversion</summary>
        [MethodImpl(MethodImplOptions.AggressiveInlining)]
        public static Color ToColor(Vector4 v)
        {
            return new Color(v.x, v.y, v.z, v.w);
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

        /// <summary>Converts texture normal vector to unity normal vector.</summary>
        [MethodImpl(MethodImplOptions.AggressiveInlining)]
        public static Vector3 ToNormal(Color c)
        {
            return (Mathx.Sub(Mathx.Mul(ToVector3(c), 2), 1)).XZY();
        }

        /// <summary>Converts unity normal vector to texture normal vector.</summary>
        [MethodImpl(MethodImplOptions.AggressiveInlining)]
        public static Color ToNormal(Vector3 v)
        {
            return ToColor((Mathx.Add(v.XZY(), 1.0f)) * 0.5f);
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
    }
}
