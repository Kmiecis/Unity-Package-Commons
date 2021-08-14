namespace Common.BehaviourTree
{
    public abstract class ADecoratorNode : INode
    {
        protected INode _node;

        public abstract ENodeState Evaluate();

        public virtual ADecoratorNode Set(INode node)
        {
            _node = node;
            return this;
        }
    }
}
