using UnityEngine;

namespace Common.Extensions
{
    public static class QuaternionExtensions
    {
        public static Vector3 GetDirection(this Quaternion self)
        {
            return (self * Vector3.forward).normalized;
        }
    }
}
