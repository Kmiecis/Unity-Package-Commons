namespace Common.BehaviourTrees
{
    public class BT_Status : BT_ADecorator
    {
        private readonly BT_EStatus _forced;

        public BT_Status(BT_EStatus forced) :
            base("Status")
        {
            _forced = forced;
        }

        protected override BT_EStatus OnUpdate(BT_ITask node)
        {
            base.OnUpdate(node);
            return _forced;
        }
    }
}
