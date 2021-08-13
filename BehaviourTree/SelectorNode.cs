namespace Common.BehaviourTree
{
    public class SelectorNode : ACompositeNode
    {
        public override ENodeState Evaluate()
        {
            foreach (var node in _nodes)
            {
                var status = node.Evaluate();
                if (status != ENodeState.Failure)
                {
                    return status;
                }
            }

            return ENodeState.Failure;
        }
    }
}
