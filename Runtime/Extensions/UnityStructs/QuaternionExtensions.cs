using System.Runtime.CompilerServices;
using UnityEngine;

namespace Common.Extensions
{
    public static class QuaternionExtensions
    {
        [MethodImpl(MethodImplOptions.AggressiveInlining)]
        public static Vector3 GetDirection(this Quaternion self)
        {
            return (self * Vector3.forward).normalized;
        }

        [MethodImpl(MethodImplOptions.AggressiveInlining)]
        public static Quaternion WithAngleX(this Quaternion self, float value)
        {
            return Quaternion.Euler(self.eulerAngles.WithX(value));
        }

        [MethodImpl(MethodImplOptions.AggressiveInlining)]
        public static Quaternion WithAngleY(this Quaternion self, float value)
        {
            return Quaternion.Euler(self.eulerAngles.WithY(value));
        }

        [MethodImpl(MethodImplOptions.AggressiveInlining)]
        public static Quaternion WithAngleZ(this Quaternion self, float value)
        {
            return Quaternion.Euler(self.eulerAngles.WithZ(value));
        }
    }
}
