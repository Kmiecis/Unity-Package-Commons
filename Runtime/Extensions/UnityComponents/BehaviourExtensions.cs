using UnityEngine;

namespace Common
{
    public static class BehaviourExtensions
    {
        public static void Enable(this Behaviour self)
        {
            self.enabled = true;
        }

        public static void Disable(this Behaviour self)
        {
            self.enabled = false;
        }
    }
}