using System;

namespace Common.StateMachines
{
    /// <summary>
    /// Base <see cref="SM_ITransition"/> implementation
    /// </summary>
    public abstract class SM_ATransition<T> : SM_ITransition
        where T : SM_IState
    {
        protected readonly Type _target = typeof(T);

        public Type Target
        {
            get => _target;
        }

        public abstract bool IsValid();
    }
}
