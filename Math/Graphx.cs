using Common.Extensions;
using System.Runtime.CompilerServices;
using UnityEngine;

namespace Common
{
    public static class Graphx
    {
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
    }
}
