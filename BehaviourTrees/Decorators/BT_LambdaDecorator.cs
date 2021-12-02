namespace Common.BehaviourTrees
{
    public sealed class BT_LambdaDecorator : BT_ADecorator
    {
        public delegate BT_EStatus DecorateDelegate(BT_EStatus status);

        private DecorateDelegate _decorate;

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
