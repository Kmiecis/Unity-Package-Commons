using System.Runtime.CompilerServices;
using UnityEngine;

namespace Common.Extensions
{
    public static class Vector3IntExtensions
    {
        [MethodImpl(MethodImplOptions.AggressiveInlining)]
        public static Vector2Int XY(this Vector3Int self)
        {
            return new Vector2Int(self.x, self.y);
        }

        [MethodImpl(MethodImplOptions.AggressiveInlining)]
        public static Vector2Int XZ(this Vector3Int self)
        {
            return new Vector2Int(self.x, self.z);
        }

        [MethodImpl(MethodImplOptions.AggressiveInlining)]
        public static Vector2Int YZ(this Vector3Int self)
        {
            return new Vector2Int(self.y, self.z);
        }

        [MethodImpl(MethodImplOptions.AggressiveInlining)]
        public static Vector3Int WithX(this Vector3Int self, int x)
        {
            return new Vector3Int(x, self.y, self.z);
        }

        [MethodImpl(MethodImplOptions.AggressiveInlining)]
        public static Vector3Int WithY(this Vector3Int self, int y)
        {
            return new Vector3Int(self.x, y, self.z);
        }

        [MethodImpl(MethodImplOptions.AggressiveInlining)]
        public static Vector3Int WithZ(this Vector3Int self, int z)
        {
            return new Vector3Int(self.x, self.y, z);
        }

        [MethodImpl(MethodImplOptions.AggressiveInlining)]
        public static Vector3 Normalized(this Vector3Int self)
        {
            var l = self.magnitude;
            return new Vector3(self.x / l, self.y / l, self.z / l);
        }
    }
}
