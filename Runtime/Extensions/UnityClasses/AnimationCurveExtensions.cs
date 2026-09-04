using UnityEngine;

namespace Common
{
    public static class AnimationCurveExtensions
    {
        public static Vector2 Evaluate(this AnimationCurve self, Vector2 time)
        {
            time.x = self.Evaluate(time.x);
            time.y = self.Evaluate(time.y);
            return time;
        }

        public static Vector3 Evaluate(this AnimationCurve self, Vector3 time)
        {
            time.x = self.Evaluate(time.x);
            time.y = self.Evaluate(time.y);
            time.z = self.Evaluate(time.z);
            return time;
        }

        public static float GetDuration(this AnimationCurve self)
        {
            if (self.length < 2)
                return 0.0f;
            return Mathf.Abs(self[self.length - 1].time - self[0].time);
        }

        public static float GetLength(this AnimationCurve self)
        {
            if (self.length < 2)
                return 0.0f;
            return Mathf.Abs(self[self.length - 1].value - self[0].value);
        }
    }
}