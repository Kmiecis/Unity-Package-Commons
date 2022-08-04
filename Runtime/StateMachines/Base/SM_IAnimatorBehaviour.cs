using UnityEngine;

namespace Common.StateMachines
{
    public interface SM_IAnimatorBehaviour<T>
    {
        void Setup(Animator animator, T context);
        void Enable();
        void Disable();
    }
}
