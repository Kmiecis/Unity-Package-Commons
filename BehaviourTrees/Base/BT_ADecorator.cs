namespace Common.BehaviourTrees
{
    public abstract class BT_ADecorator : BT_ADecizer
    {
        public BT_ADecorator(string name = null) :
            base(name)
        {
        }

        protected abstract BT_EStatus Decorate(BT_EStatus status);

        protected override BT_EStatus OnUpdate(BT_ITask node)
        {
            var result = base.OnUpdate(node);
            return Decorate(result);
        }
    }
}
