namespace Common.BehaviourTree
{
    public class RepeaterWhileNode : ADecoratorNode
    {
        protected ENodeState _status;

        public RepeaterWhileNode(ENodeState status)
        {
            _status = status;
        }

        public override ENodeState Evaluate()
        {
            var status = _node.Evaluate();
            if (status == _status)
            {
                return ENodeState.Running;
            }
            return status;
        }
    }
}
