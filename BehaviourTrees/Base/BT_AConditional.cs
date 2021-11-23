namespace Common.BehaviourTrees
{
    public abstract class BT_AConditional : BT_ADecizer
    {
        public BT_AConditional(string name = null) :
            base(name)
        {
        }

        protected abstract bool CanExecute();

        protected override BT_EStatus OnUpdate(BT_ITask node)
        {
            if (CanExecute())
            {
                return base.OnUpdate(node);
            }
            return BT_EStatus.Failure;
        }
    }
}
