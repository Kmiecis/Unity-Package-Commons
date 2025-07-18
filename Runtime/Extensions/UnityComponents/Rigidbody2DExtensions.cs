using UnityEngine;

namespace Common
{
    public static class Rigidbody2DExtensions
    {
        public static Vector2 GetLocalVelocity(this Rigidbody2D self)
        {
#if UNITY_6000_0_OR_NEWER
            var velocity = self.linearVelocity;
#else
            var velocity = self.velocity;
#endif
            return self.transform.InverseTransformDirection(velocity);
        }

        public static void SetLocalVelocity(this Rigidbody2D self, Vector2 velocity)
        {
            velocity = self.transform.TransformDirection(velocity);
#if UNITY_6000_0_OR_NEWER
            self.linearVelocity = velocity;
#else
            self.velocity = velocity;
#endif
        }
    }
}
