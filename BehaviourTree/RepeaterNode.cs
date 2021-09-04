namespace Common.BehaviourTree
{
    public class RepeaterNode : StatusNode
    {
        public RepeaterNode() :
            base(ENodeState.Running)
        {
        }
    }
}
