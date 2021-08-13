using System.Collections.Generic;

namespace Common.BehaviourTree
{
    public abstract class ACompositeNode : ANode
    {
        protected List<ANode> _nodes = new List<ANode>();

        public virtual ACompositeNode Add(ANode node)
        {
            _nodes.Add(node);
            return this;
        }

        public virtual ACompositeNode Add(params ANode[] nodes)
        {
            _nodes.AddRange(nodes);
            return this;
        }
    }
}
