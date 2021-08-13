namespace Common.BehaviourTree
{
    public class FailureRepeaterNode : RepeaterWhileNode
    {
        public FailureRepeaterNode() :
            base(ENodeState.Failure)
        {
        }
    }
}
