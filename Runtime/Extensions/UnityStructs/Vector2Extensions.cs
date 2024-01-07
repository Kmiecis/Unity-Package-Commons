using System.Runtime.CompilerServices;
using UnityEngine;

namespace Common.Extensions
{
    public static class Vector2Extensions
    {
        [MethodImpl(MethodImplOptions.AggressiveInlining)]
        public static Vector3 XY_(this Vector2 self, float f = 0.0f)
        {
            return new Vector3(self.x, self.y, f);
        }

        [MethodImpl(MethodImplOptions.AggressiveInlining)]
        public static Vector3 X_Y(this Vector2 self, float f = 0.0f)
        {
            return new Vector3(self.x, f, self.y);
        }

        [MethodImpl(MethodImplOptions.AggressiveInlining)]
        public static Vector3 _XY(this Vector2 self, float f = 0.0f)
        {
            return new Vector3(f, self.x, self.y);
        }

        [MethodImpl(MethodImplOptions.AggressiveInlining)]
        public static Vector3 YX_(this Vector2 self, float f = 0.0f)
        {
            return new Vector3(self.y, self.x, f);
        }

        [MethodImpl(MethodImplOptions.AggressiveInlining)]
        public static Vector3 Y_X(this Vector2 self, float f = 0.0f)
        {
            return new Vector3(self.y, f, self.x);
        }

        [MethodImpl(MethodImplOptions.AggressiveInlining)]
        public static Vector3 _YX(this Vector2 self, float f = 0.0f)
        {
            return new Vector3(f, self.y, self.x);
        }

        [MethodImpl(MethodImplOptions.AggressiveInlining)]
        public static Vector2 YX(this Vector2 self)
        {
            return new Vector2(self.y, self.x);
        }

        [MethodImpl(MethodImplOptions.AggressiveInlining)]
        public static Vector2 WithX(this Vector2 self, float x)
        {
            return new Vector2(x, self.y);
        }

        [MethodImpl(MethodImplOptions.AggressiveInlining)]
        public static Vector2 WithY(this Vector2 self, float y)
        {
            return new Vector2(self.x, y);
        }
    }
}
