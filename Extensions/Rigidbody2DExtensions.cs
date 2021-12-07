using UnityEngine;

namespace Common.Extensions
{
    public static class Rigidbody2DExtensions
    {
        public static Vector2 GetLocalVelocity(this Rigidbody2D self)
        {
            return self.transform.InverseTransformDirection(self.velocity);
        }

        public static void SetLocalVelocity(this Rigidbody2D self, Vector2 velocity)
        {
            self.velocity = self.transform.TransformDirection(velocity);
        }
    }
}
