using System.Runtime.CompilerServices;
using UnityEngine;

namespace Common.Extensions
{
    public static class Vector3Extensions
    {
        [MethodImpl(MethodImplOptions.AggressiveInlining)]
        public static Vector2 XY(this Vector3 self)
            => new Vector2(self.x, self.y);

        [MethodImpl(MethodImplOptions.AggressiveInlining)]
        public static Vector2 XZ(this Vector3 self)
            => new Vector2(self.x, self.z);

        [MethodImpl(MethodImplOptions.AggressiveInlining)]
        public static Vector2 YZ(this Vector3 self)
            => new Vector2(self.y, self.z);

        [MethodImpl(MethodImplOptions.AggressiveInlining)]
        public static Vector3 X__(this Vector3 self, float y = 0.0f, float z = 0.0f)
            => new Vector3(self.x, y, z);

        [MethodImpl(MethodImplOptions.AggressiveInlining)]
        public static Vector3 _X_(this Vector3 self, float x = 0.0f, float z = 0.0f)
            => new Vector3(x, self.x, z);

        [MethodImpl(MethodImplOptions.AggressiveInlining)]
        public static Vector3 __X(this Vector3 self, float x = 0.0f, float y = 0.0f)
            => new Vector3(x, y, self.x);

        [MethodImpl(MethodImplOptions.AggressiveInlining)]
        public static Vector3 Y__(this Vector3 self, float y = 0.0f, float z = 0.0f)
            => new Vector3(self.y, y, z);

        [MethodImpl(MethodImplOptions.AggressiveInlining)]
        public static Vector3 _Y_(this Vector3 self, float x = 0.0f, float z = 0.0f)
            => new Vector3(x, self.y, z);

        [MethodImpl(MethodImplOptions.AggressiveInlining)]
        public static Vector3 __Y(this Vector3 self, float x = 0.0f, float y = 0.0f)
            => new Vector3(x, y, self.y);

        [MethodImpl(MethodImplOptions.AggressiveInlining)]
        public static Vector3 Z__(this Vector3 self, float y = 0.0f, float z = 0.0f)
            => new Vector3(self.z, y, z);

        [MethodImpl(MethodImplOptions.AggressiveInlining)]
        public static Vector3 _Z_(this Vector3 self, float x = 0.0f, float z = 0.0f)
            => new Vector3(x, self.z, z);

        [MethodImpl(MethodImplOptions.AggressiveInlining)]
        public static Vector3 __Z(this Vector3 self, float x = 0.0f, float y = 0.0f)
            => new Vector3(x, y, self.z);

        [MethodImpl(MethodImplOptions.AggressiveInlining)]
        public static Vector3 XY_(this Vector3 self, float z = 0.0f)
            => new Vector3(self.x, self.y, z);

        [MethodImpl(MethodImplOptions.AggressiveInlining)]
        public static Vector3 X_Z(this Vector3 self, float y = 0.0f)
            => new Vector3(self.x, y, self.z);

        [MethodImpl(MethodImplOptions.AggressiveInlining)]
        public static Vector3 _YZ(this Vector3 self, float x = 0.0f)
            => new Vector3(x, self.y, self.z);

        [MethodImpl(MethodImplOptions.AggressiveInlining)]
        public static Vector3 XZY(this Vector3 self)
            => new Vector3(self.x, self.z, self.y);

        [MethodImpl(MethodImplOptions.AggressiveInlining)]
        public static Vector3 YXZ(this Vector3 self)
            => new Vector3(self.y, self.x, self.z);

        [MethodImpl(MethodImplOptions.AggressiveInlining)]
        public static Vector3 YZX(this Vector3 self)
            => new Vector3(self.y, self.z, self.x);

        [MethodImpl(MethodImplOptions.AggressiveInlining)]
        public static Vector3 ZXY(this Vector3 self)
            => new Vector3(self.z, self.x, self.y);

        [MethodImpl(MethodImplOptions.AggressiveInlining)]
        public static Vector3 ZYX(this Vector3 self)
            => new Vector3(self.z, self.y, self.x);

        [MethodImpl(MethodImplOptions.AggressiveInlining)]
        public static Vector4 XYZ_(this Vector3 self, float w = 0.0f)
            => new Vector4(self.x, self.y, self.z, w);

        [MethodImpl(MethodImplOptions.AggressiveInlining)]
        public static Color RGB(this Vector3 self)
            => new Color(self.x, self.y, self.z);

        [MethodImpl(MethodImplOptions.AggressiveInlining)]
        public static Color RGBA(this Vector3 self, float a = 1.0f)
            => new Color(self.x, self.y, self.z, a);
    }
}
