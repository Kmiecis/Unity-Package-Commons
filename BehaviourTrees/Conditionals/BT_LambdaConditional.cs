namespace Common.BehaviourTrees
{
    public sealed class BT_LambdaConditional : BT_AConditional
    {
        public delegate bool CanExecuteDelegate();

        private CanExecuteDelegate _canExecute;

        public CanExecuteDelegate CanExecuteAction
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
