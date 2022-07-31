namespace Common.StateMachines
{
    /// <summary>
    /// <see cref="SM_ATransition{T}"/> with custom delegate support
    /// </summary>
    public class SM_DelegateTransition<T> : SM_ATransition<T>
        where T : SM_IState
    {
        public delegate bool IsValidDelegate();

        protected IsValidDelegate _isValid;

        public IsValidDelegate IsValidAction
        {
            set => _isValid = value;
        }

        public override bool IsValid()
        {
            if (_isValid != null)
            {
                return _isValid();
            }
            return false;
        }
    }
}
