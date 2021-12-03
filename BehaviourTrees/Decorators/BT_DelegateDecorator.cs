namespace Common.BehaviourTrees
{
    /// <summary>
    /// <see cref="BT_ADecorator"/> with custom delegate support
    /// </summary>
    public sealed class BT_DelegateDecorator : BT_ADecorator
    {
        public delegate BT_EStatus DecorateDelegate(BT_EStatus status);

        private DecorateDelegate _decorate;

        public BT_DelegateDecorator(string name = "Delegate") :
            base(name)
        {
        }

        public DecorateDelegate DecorateAction
        {
            set => _decorate = value;
        }

        public override BT_EStatus Decorate(BT_EStatus status)
        {
            if (_decorate != null)
            {
                return _decorate(status);
            }
            return status;
        }
    }
}
