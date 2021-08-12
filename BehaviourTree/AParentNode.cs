namespace Common.BehaviourTree
{
    public abstract class AParentNode : ANode
    {
        public abstract AParentNode Add(ANode node);
    }
}
