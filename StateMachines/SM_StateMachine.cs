using System;
using System.Collections.Generic;

namespace Common.StateMachines
{
    /// <summary>
    /// Base <see cref="SM_IStateMachine"/> implementation
    /// </summary>
    public sealed class SM_StateMachine : SM_IStateMachine
    {
        private readonly Dictionary<Type, SM_IState> _states = new Dictionary<Type, SM_IState>();
        private SM_IState _state;

        public SM_IState[] States
        {
            set
            {
                _state = value[0];
                foreach (var state in value)
                {
                    _states[state.GetType()] = state;
                }
            }
        }

        public void Execute()
        {
            var newStateType = _state.Execute();

            if (newStateType != null)
            {
                _state = _states[newStateType];
            }
        }
    }
}
