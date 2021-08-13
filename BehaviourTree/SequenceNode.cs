namespace Common.BehaviourTree
{
    public class SequenceNode : ACompositeNode
    {
        public override ENodeState Evaluate()
        {
            foreach (var node in _nodes)
            {
                var status = node.Evaluate();
                if (status != ENodeState.Success)
                {
                    return status;
                }
            }

            return ENodeState.Success;
        }
    }
}
