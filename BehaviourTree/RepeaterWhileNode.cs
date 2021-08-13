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
            if (_node.Evaluate() == _status)
            {
                return ENodeState.Running;
            }
            return ENodeState.Success;
        }
    }
}
