namespace Common.BehaviourTrees
{
    /// <summary>
    /// <see cref="BT_AConditional"/> with custom delegate support
    /// </summary>
    public sealed class BT_DelegateConditional : BT_AConditional
    {
        public delegate bool CanExecuteDelegate();

        private CanExecuteDelegate _canExecute;

        public BT_DelegateConditional(string name = "Delegate") :
            base(name)
        {
        }

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
