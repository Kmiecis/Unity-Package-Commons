namespace Common.BehaviourTrees
{
    public class BT_Status : BT_ADecorator
    {
        private readonly BT_EStatus _status;

        public BT_Status(BT_EStatus status) :
            base("Status")
        {
            _status = status;
        }

        public override BT_EStatus Decorate(BT_EStatus status)
        {
            return _status;
        }
    }
}
