using System.Runtime.CompilerServices;
using UnityEngine;

namespace Common.Extensions
{
    public static class Vector4Extensions
    {
        [MethodImpl(MethodImplOptions.AggressiveInlining)]
        public static Color RGBA(this Vector4 self)
        {
            return new Color(self.x, self.y, self.z, self.w);
        }

        [MethodImpl(MethodImplOptions.AggressiveInlining)]
        public static Vector4 WithX(this Vector4 self, float value)
        {
            return new Vector4(value, self.y, self.z, self.w);
        }

        [MethodImpl(MethodImplOptions.AggressiveInlining)]
        public static Vector4 WithY(this Vector4 self, float value)
        {
            return new Vector4(self.x, value, self.z, self.w);
        }

        [MethodImpl(MethodImplOptions.AggressiveInlining)]
        public static Vector4 WithZ(this Vector4 self, float value)
        {
            return new Vector4(self.x, self.y, value, self.w);
        }

        [MethodImpl(MethodImplOptions.AggressiveInlining)]
        public static Vector4 WithW(this Vector4 self, float value)
        {
            return new Vector4(self.x, self.y, self.z, value);
        }
    }
}
