namespace Common.BehaviourTree
{
    public class InverterNode : ADecoratorNode
    {
        public override ENodeState Evaluate()
        {
            var status = _node.Evaluate();

            if (status == ENodeState.Success)
            {
                return ENodeState.Failure;
            }

            if (status == ENodeState.Failure)
            {
                return ENodeState.Success;
            }

            return status;
        }
    }
}
