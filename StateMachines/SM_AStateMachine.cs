using System;
using System.Collections.Generic;
using Common.Collections;
using Common.Extensions;

namespace Common.StateMachine
{
    public abstract class AStateMachine
    {
        protected readonly Dictionary<Type, SM_IState> _states = new Dictionary<Type, SM_IState>();
        protected readonly Dictionary<Type, List<(Type type, Func<bool> when)>> _transitions = new Dictionary<Type, List<(Type type, Func<bool> when)>>();

        protected SM_IState _state;
        
        public AStateMachine AddState(SM_IState state)
        {
            _states.Add(state.GetType(), state);
            return this;
        }
        
        public AStateMachine AddTransition<TFromState, TToState>(Func<bool> when)
            where TFromState : SM_IState
            where TToState : SM_IState
        {
            var fromStateType = typeof(TFromState);
            var toStateType = typeof(TToState);
            _transitions.GetOrCompute(fromStateType, Lists.New<(Type type, Func<bool> when)>)
                .Add((toStateType, when));
            return this;
        }

        public bool IsState<T>()
            where T : SM_IState
        {
            return _state is T;
        }

        public void RemoveState<T>()
            where T : SM_IState
        {
            var type = typeof(T);
            _states.Remove(type);
            _transitions.Remove(type);
        }

        public void OnUpdate()
        {
            _state.OnUpdate();

            if (TryGetSwitchState(_state, out var newState))
            {
                _state.OnFinish();
                _state = newState;
                _state.OnStart();
            }
        }

        private bool TryGetSwitchState(SM_IState oldState, out SM_IState newState)
        {
            var oldStateType = oldState.GetType();

            foreach (var transition in _transitions[oldStateType])
            {
                if (transition.when())
                {
                    newState = _states[transition.type];
                    return true;
                }
            }

            newState = default;
            return false;
        }
    }
}
