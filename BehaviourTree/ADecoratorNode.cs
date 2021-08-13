namespace Common.BehaviourTree
{
    public abstract class ADecoratorNode : ANode
    {
        protected ANode _node;

        public virtual ADecoratorNode Set(ANode node)
        {
            _node = node;
            return this;
        }
    }
}
