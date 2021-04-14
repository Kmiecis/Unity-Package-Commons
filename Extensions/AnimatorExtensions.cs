using UnityEngine;

namespace Common
{
    public static class AnimatorExtensions
    {
        public static void SetTrigger(this Animator self, int id, bool active)
        {
            if (active)
                self.SetTrigger(id);
            else
                self.ResetTrigger(id);
        }
    }
}