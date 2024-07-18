using System.Runtime.CompilerServices;
using UnityEngine;

namespace Common.Extensions
{
    public static class Vector3Extensions
    {
        [MethodImpl(MethodImplOptions.AggressiveInlining)]
        public static Color RGB(this Vector3 self)
        {
            return new Color(self.x, self.y, self.z);
        }

        [MethodImpl(MethodImplOptions.AggressiveInlining)]
        public static Vector2 XY(this Vector3 self)
        {
            return new Vector2(self.x, self.y);
        }

        [MethodImpl(MethodImplOptions.AggressiveInlining)]
        public static Vector2 XZ(this Vector3 self)
        {
            return new Vector2(self.x, self.z);
        }

        [MethodImpl(MethodImplOptions.AggressiveInlining)]
        public static Vector2 YZ(this Vector3 self)
        {
            return new Vector2(self.y, self.z);
        }

        [MethodImpl(MethodImplOptions.AggressiveInlining)]
        public static Vector3 XZY(this Vector3 self)
        {
            return new Vector3(self.x, self.z, self.y);
        }

        [MethodImpl(MethodImplOptions.AggressiveInlining)]
        public static Vector3 YXZ(this Vector3 self)
        {
            return new Vector3(self.y, self.x, self.z);
        }

        [MethodImpl(MethodImplOptions.AggressiveInlining)]
        public static Vector3 YZX(this Vector3 self)
        {
            return new Vector3(self.y, self.z, self.x);
        }

        [MethodImpl(MethodImplOptions.AggressiveInlining)]
        public static Vector3 ZXY(this Vector3 self)
        {
            return new Vector3(self.z, self.x, self.y);
        }

        [MethodImpl(MethodImplOptions.AggressiveInlining)]
        public static Vector3 ZYX(this Vector3 self)
        {
            return new Vector3(self.z, self.y, self.x);
        }

        [MethodImpl(MethodImplOptions.AggressiveInlining)]
        public static Vector3 WithX(this Vector3 self, float x)
        {
            return new Vector3(x, self.y, self.z);
        }

        [MethodImpl(MethodImplOptions.AggressiveInlining)]
        public static Vector3 WithY(this Vector3 self, float y)
        {
            return new Vector3(self.x, y, self.z);
        }

        [MethodImpl(MethodImplOptions.AggressiveInlining)]
        public static Vector3 WithZ(this Vector3 self, float z)
        {
            return new Vector3(self.x, self.y, z);
        }

        [MethodImpl(MethodImplOptions.AggressiveInlining)]
        public static Vector3 WithXY(this Vector3 self, float x, float y)
        {
            return new Vector3(x, y, self.z);
        }

        [MethodImpl(MethodImplOptions.AggressiveInlining)]
        public static Vector3 WithXZ(this Vector3 self, float x, float z)
        {
            return new Vector3(x, self.y, z);
        }

        [MethodImpl(MethodImplOptions.AggressiveInlining)]
        public static Vector3 WithYZ(this Vector3 self, float y, float z)
        {
            return new Vector3(self.x, y, z);
        }
    }
}
