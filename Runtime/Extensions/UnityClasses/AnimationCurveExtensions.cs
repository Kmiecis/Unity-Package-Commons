using UnityEngine;

namespace Common
{
    public static class AnimationCurveExtensions
    {
        public static float GetDuration(this AnimationCurve self)
        {
            if (self.length <= 1)
                return 0.0f;
            return Mathf.Abs(self[self.length - 1].time - self[0].time);
        }
    }
}