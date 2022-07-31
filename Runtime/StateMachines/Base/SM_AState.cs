using System;

namespace Common.StateMachines
{
    /// <summary>
    /// Base <see cref="SM_IState"/> implementation
    /// </summary>
    public abstract class SM_AState : SM_IState
    {
        protected string _name;
        protected bool _started;

        protected SM_ITransition[] _transitions;

        public SM_AState(string name = null)
        {
            _name = name ?? GetType().Name;
        }

        public string Name
        {
            get => _name;
        }

        public SM_ITransition[] Transitions
        {
            set => _transitions = value;
        }

        public SM_ITransition Transition
        {
            set => _transitions = new SM_ITransition[] { value };
        }

        public Type Execute()
        {
            if (!_started)
            {
                OnStart();
            }

            var result = OnUpdate();

            if (
                result != null &&
                _started
            )
            {
                OnFinish();
            }

            return result;
        }

        protected Type GetTransition()
        {
            if (_transitions != null)
            {
                foreach (var transition in _transitions)
                {
                    if (transition.IsValid())
                    {
                        return transition.Target;
                    }
                }
            }
            return null;
        }

        protected virtual void OnStart()
        {
            _started = true;
        }

        protected virtual Type OnUpdate()
        {
            return GetTransition();
        }

        protected virtual void OnFinish()
        {
            _started = false;
        }
    }

    /// <summary>
    /// <see cref="SM_AState"/> implementation with build-in context <see cref="T"/> support of any type
    /// </summary>
    public abstract class SM_AState<T> : SM_AState
    {
        protected readonly T _context;

        public SM_AState(T context, string name = null) :
            base(name)
        {
            _context = context;
        }
    }
}
