namespace Common.BehaviourTree
{
    public class FailerNode : StatusNode
    {
        public FailerNode() :
            base(ENodeState.Failure)
        {
        }
    }
}
