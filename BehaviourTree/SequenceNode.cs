using System.Collections.Generic;

namespace Common.BehaviourTree
{
    public class SequenceNode : AParentNode
    {
        protected List<ANode> _nodes = new List<ANode>();

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

        public override AParentNode Add(ANode node)
        {
            _nodes.Add(node);
            return this;
        }
    }
}
