using System.Runtime.CompilerServices;
using UnityEngine;

namespace Common.Extensions
{
    public static class Vector2Extensions
    {
        [MethodImpl(MethodImplOptions.AggressiveInlining)]
        public static Vector2 X_(this Vector2 self, float y = 0.0f)
            => new Vector2(self.x, y);

        [MethodImpl(MethodImplOptions.AggressiveInlining)]
        public static Vector2 _Y(this Vector2 self, float x = 0.0f)
            => new Vector2(x, self.y);

        [MethodImpl(MethodImplOptions.AggressiveInlining)]
        public static Vector2 YX(this Vector2 self)
            => new Vector2(self.y, self.x);

        [MethodImpl(MethodImplOptions.AggressiveInlining)]
        public static Vector3 X__(this Vector2 self, float y = 0.0f, float z = 0.0f)
            => new Vector3(self.x, y, z);

        [MethodImpl(MethodImplOptions.AggressiveInlining)]
        public static Vector3 _X_(this Vector2 self, float x = 0.0f, float z = 0.0f)
            => new Vector3(x, self.x, z);

        [MethodImpl(MethodImplOptions.AggressiveInlining)]
        public static Vector3 __X(this Vector2 self, float x = 0.0f, float y = 0.0f)
            => new Vector3(x, y, self.x);

        [MethodImpl(MethodImplOptions.AggressiveInlining)]
        public static Vector3 Y__(this Vector2 self, float y = 0.0f, float z = 0.0f)
            => new Vector3(self.y, y, z);

        [MethodImpl(MethodImplOptions.AggressiveInlining)]
        public static Vector3 _Y_(this Vector2 self, float x = 0.0f, float z = 0.0f)
            => new Vector3(x, self.y, z);

        [MethodImpl(MethodImplOptions.AggressiveInlining)]
        public static Vector3 __Y(this Vector2 self, float x = 0.0f, float y = 0.0f)
            => new Vector3(x, y, self.y);

        [MethodImpl(MethodImplOptions.AggressiveInlining)]
        public static Vector3 XY_(this Vector2 self, float f = 0.0f)
            => new Vector3(self.x, self.y, f);

        [MethodImpl(MethodImplOptions.AggressiveInlining)]
        public static Vector3 X_Y(this Vector2 self, float f = 0.0f)
            => new Vector3(self.x, f, self.y);

        [MethodImpl(MethodImplOptions.AggressiveInlining)]
        public static Vector3 _XY(this Vector2 self, float f = 0.0f)
            => new Vector3(f, self.x, self.y);

        [MethodImpl(MethodImplOptions.AggressiveInlining)]
        public static Vector3 YX_(this Vector2 self, float f = 0.0f)
            => new Vector3(self.y, self.x, f);

        [MethodImpl(MethodImplOptions.AggressiveInlining)]
        public static Vector3 Y_X(this Vector2 self, float f = 0.0f)
            => new Vector3(self.y, f, self.x);

        [MethodImpl(MethodImplOptions.AggressiveInlining)]
        public static Vector3 _YX(this Vector2 self, float f = 0.0f)
            => new Vector3(f, self.y, self.x);

        [MethodImpl(MethodImplOptions.AggressiveInlining)]
        public static Vector2 Add(this Vector2 self, float f)
            => new Vector2(self.x + f, self.y + f);

        [MethodImpl(MethodImplOptions.AggressiveInlining)]
        public static Vector2 Add(this Vector2 self, int i)
            => new Vector2(self.x + i, self.y + i);

        [MethodImpl(MethodImplOptions.AggressiveInlining)]
        public static Vector2 Sub(this Vector2 self, float f)
            => new Vector2(self.x - f, self.y - f);

        [MethodImpl(MethodImplOptions.AggressiveInlining)]
        public static Vector2 Sub(this Vector2 self, int i)
            => new Vector2(self.x - i, self.y - i);
    }
}
