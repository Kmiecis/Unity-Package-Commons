using System;

namespace Common.StateMachines
{
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
                    if (transition.CanTransit())
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
