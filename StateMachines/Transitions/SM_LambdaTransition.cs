using System;

namespace Common.StateMachines
{
    public class SM_LambdaTransition<T> : SM_ATransition<T>
    {
        protected Func<bool> _canTransit;

        public Func<bool> CanTransitCall
        {
            set => _canTransit = value;
        }

        public override bool CanTransit()
        {
            if (_canTransit != null)
            {
                return _canTransit();
            }
            return false;
        }
    }
}
