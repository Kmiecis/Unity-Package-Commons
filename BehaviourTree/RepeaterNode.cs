namespace Common.BehaviourTree
{
    public class RepeaterNode : ADecoratorNode
    {
        protected int _repeats;

        public RepeaterNode(int repeats)
        {
            _repeats = repeats;
        }

        public override ENodeState Evaluate()
        {
            _node.Evaluate();
            _repeats--;
            return _repeats > 0 ? ENodeState.Running : ENodeState.Success;
        }
    }
}
