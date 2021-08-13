namespace Common.BehaviourTree
{
    public class StatusNode : ADecoratorNode
    {
        protected ENodeState _status;

        public StatusNode(ENodeState status)
        {
            _status = status;
        }

        public override ENodeState Evaluate()
        {
            _node.Evaluate();
            return _status;
        }
    }
}
