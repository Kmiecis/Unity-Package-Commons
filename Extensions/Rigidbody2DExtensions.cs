using System.Runtime.CompilerServices;
using UnityEngine;

namespace Common.Extensions
{
    public static class Rigidbody2DExtensions
    {
        [MethodImpl(MethodImplOptions.AggressiveInlining)]
        public static Vector2 GetLocalVelocity(this Rigidbody2D self)
        {
            return self.transform.InverseTransformDirection(self.velocity);
        }

        [MethodImpl(MethodImplOptions.AggressiveInlining)]
        public static void SetLocalVelocity(this Rigidbody2D self, Vector2 velocity)
        {
            self.velocity = self.transform.TransformDirection(velocity);
        }
    }
}
