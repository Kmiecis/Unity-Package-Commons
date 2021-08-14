namespace Common.BehaviourTree
{
    public abstract class ATargetNode<T> : INode
    {
        protected T _target;

        public ATargetNode(T target)
        {
            _target = target;
        }

        public abstract ENodeState Evaluate();
    }
}
