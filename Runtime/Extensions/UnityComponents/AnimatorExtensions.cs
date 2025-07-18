using System.Collections.Generic;
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

        public static IEnumerable<T> GetBehaviours<T>(this Animator animator)
        {
            var behaviours = animator.GetBehaviours<StateMachineBehaviour>();
            if (behaviours != null)
            {
                foreach (var behaviour in behaviours)
                {
                    if (behaviour is T casted)
                    {
                        yield return casted;
                    }
                }
            }
        }
    }
}
