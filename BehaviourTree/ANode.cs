namespace Common.BehaviourTree
{
    public abstract class ANode
    {
        protected ENodeState _nodeState;

        public ENodeState NodeState => _nodeState;

        public abstract ENodeState Evaluate();
    }
}
