using System.Runtime.CompilerServices;
using UnityEngine;

namespace Common
{
    public static class QuaternionExtensions
    {
        [MethodImpl(MethodImplOptions.AggressiveInlining)]
        public static Vector3 GetDirection(this Quaternion self)
            => (self * Vector3.forward).normalized;

        [MethodImpl(MethodImplOptions.AggressiveInlining)]
        public static Quaternion GetRotationX(this Quaternion self)
            => new Quaternion(self.x, 0.0f, 0.0f, self.w / Mathf.Sqrt(self.w * self.w + self.x * self.x));

        [MethodImpl(MethodImplOptions.AggressiveInlining)]
        public static Quaternion GetRotationY(this Quaternion self)
            => new Quaternion(0.0f, self.y, 0.0f, self.w / Mathf.Sqrt(self.w * self.w + self.y * self.y));

        [MethodImpl(MethodImplOptions.AggressiveInlining)]
        public static Quaternion GetRotationZ(this Quaternion self)
            => new Quaternion(0.0f, 0.0f, self.z, self.w / Mathf.Sqrt(self.w * self.w + self.z * self.z));

        [MethodImpl(MethodImplOptions.AggressiveInlining)]
        public static Quaternion GetRotationXY(this Quaternion self)
            => self.GetRotationX() * self.GetRotationY();

        [MethodImpl(MethodImplOptions.AggressiveInlining)]
        public static Quaternion GetRotationXZ(this Quaternion self)
            => self.GetRotationX() * self.GetRotationZ();

        [MethodImpl(MethodImplOptions.AggressiveInlining)]
        public static Quaternion GetRotationYZ(this Quaternion self)
            => self.GetRotationY() * self.GetRotationZ();

        [MethodImpl(MethodImplOptions.AggressiveInlining)]
        public static Quaternion WithAngleX(this Quaternion self, float value)
            => Quaternion.Euler(self.eulerAngles._YZ(value));

        [MethodImpl(MethodImplOptions.AggressiveInlining)]
        public static Quaternion WithAngleY(this Quaternion self, float value)
            => Quaternion.Euler(self.eulerAngles.X_Z(value));

        [MethodImpl(MethodImplOptions.AggressiveInlining)]
        public static Quaternion WithAngleZ(this Quaternion self, float value)
            => Quaternion.Euler(self.eulerAngles.XY_(value));
    }
}
