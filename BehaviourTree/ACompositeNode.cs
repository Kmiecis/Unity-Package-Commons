using System.Collections.Generic;

namespace Common.BehaviourTree
{
    public abstract class ACompositeNode : INode
    {
        protected List<INode> _nodes = new List<INode>();

        public abstract ENodeState Evaluate();
        
        public virtual ACompositeNode Add(params INode[] nodes)
        {
            _nodes.AddRange(nodes);
            return this;
        }
    }
}
