using System.Runtime.CompilerServices;
using UnityEngine;

namespace Common.Extensions
{
    public static class Vector4Extensions
    {
        [MethodImpl(MethodImplOptions.AggressiveInlining)]
        public static Vector3 XYZ(this Vector4 self)
            => new Vector3(self.x, self.y, self.z);

        [MethodImpl(MethodImplOptions.AggressiveInlining)]
        public static Vector4 _YZW(this Vector4 self, float value)
            => new Vector4(value, self.y, self.z, self.w);

        [MethodImpl(MethodImplOptions.AggressiveInlining)]
        public static Vector4 X_ZW(this Vector4 self, float value)
            => new Vector4(self.x, value, self.z, self.w);

        [MethodImpl(MethodImplOptions.AggressiveInlining)]
        public static Vector4 XY_W(this Vector4 self, float value)
            => new Vector4(self.x, self.y, value, self.w);

        [MethodImpl(MethodImplOptions.AggressiveInlining)]
        public static Vector4 XYZ_(this Vector4 self, float value)
            => new Vector4(self.x, self.y, self.z, value);

        [MethodImpl(MethodImplOptions.AggressiveInlining)]
        public static Color RGBA(this Vector4 self)
            => new Color(self.x, self.y, self.z, self.w);
    }
}
