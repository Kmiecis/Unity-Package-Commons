namespace Common.BehaviourTree
{
    public class SuccessRepeaterNode : RepeaterWhileNode
    {
        public SuccessRepeaterNode() :
            base(ENodeState.Success)
        {
        }
    }
}
