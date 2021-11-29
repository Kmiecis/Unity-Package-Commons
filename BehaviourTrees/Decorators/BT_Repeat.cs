namespace Common.BehaviourTrees
{
    public sealed class BT_Repeat : BT_ADecorator
    {
        private readonly int _repeats;

        private int _remaining;

        public BT_Repeat(int repeats = -1) :
            base("Repeat")
        {
            _repeats = repeats;
            _remaining = repeats;
        }

        public override BT_EStatus Decorate(BT_EStatus status)
        {
            if (status == BT_EStatus.Success)
            {
                _remaining -= 1;
                if (_remaining == 0)
                {
                    return BT_EStatus.Success;
                }
                return BT_EStatus.Running;
            }

            return status;
        }

        protected override void OnStart()
        {
            base.OnStart();

            _remaining = _repeats;
        }
    }
}
