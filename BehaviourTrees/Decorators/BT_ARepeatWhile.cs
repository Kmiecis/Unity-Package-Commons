namespace Common.BehaviourTrees
{
    public abstract class BT_ARepeatWhile : BT_ADecorator
    {
        public BT_ARepeatWhile()
            : base("RepeatWhile")
        {
        }

        protected abstract bool CanUpdate();

        protected override BT_EStatus OnUpdate(BT_ITask node)
        {
            if (CanUpdate())
            {
                return base.OnUpdate(node);
            }
            else
            {
                return BT_EStatus.Failure;
            }
        }
    }
}
