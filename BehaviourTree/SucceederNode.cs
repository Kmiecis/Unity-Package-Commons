namespace Common.BehaviourTree
{
    public class SucceederNode : StatusNode
    {
        public SucceederNode() :
            base(ENodeState.Success)
        {
        }
    }
}
