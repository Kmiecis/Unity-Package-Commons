namespace Common.BehaviourTrees
{
    public class BT_ForceStatus : BT_ADecorator
    {
        private readonly BT_EStatus _forced;

        public BT_ForceStatus(BT_EStatus forced) :
            base("ForceStatus")
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
