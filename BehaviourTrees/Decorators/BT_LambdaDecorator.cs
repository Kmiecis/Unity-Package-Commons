using System;

namespace Common.BehaviourTrees
{
    public sealed class BT_LambdaDecorator : BT_ADecorator
    {
        private Func<BT_EStatus, BT_EStatus> _decorate;

        public Func<BT_EStatus, BT_EStatus> CallDecorate
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
