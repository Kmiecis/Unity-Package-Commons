using System;

namespace Common.BehaviourTrees
{
    public sealed class BT_LambdaConditional : BT_AConditional
    {
        private Func<bool> _canExecute;

        public Func<bool> CallCanExecute
        {
            set => _canExecute = value;
        }

        public override bool CanExecute()
        {
            if (_canExecute != null)
            {
                return _canExecute();
            }
            return true;
        }
    }
}
