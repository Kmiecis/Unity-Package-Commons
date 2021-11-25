namespace Common.BehaviourTrees
{
    public abstract class BT_AConditional : BT_ADecizer
    {
        public BT_AConditional(string name = null) :
            base(name)
        {
        }

        protected override BT_EStatus Decorate(BT_EStatus status)
        {
            return status;
        }
    }
}
