using System;

namespace Common.BehaviourTree
{
    public class InverterNode : AParentNode
    {
        protected ANode _node;

        public override ENodeState Evaluate()
        {
            if (_node == null)
            {
                throw new NotImplementedException($"{nameof(InverterNode)} does not have a Node set");
            }

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

        public override AParentNode Add(ANode node)
        {
            if (_node != null)
            {
                throw new ArgumentException($"{nameof(InverterNode)} already has Node set");
            }

            _node = node;
            return this;
        }
    }
}
