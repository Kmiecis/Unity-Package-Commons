using System.Collections.Generic;

namespace Common.BehaviourTree
{
    public class SelectorNode : AParentNode
    {
        protected List<ANode> _nodes = new List<ANode>();

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

        public override AParentNode Add(ANode node)
        {
            _nodes.Add(node);
            return this;
        }
    }
}
