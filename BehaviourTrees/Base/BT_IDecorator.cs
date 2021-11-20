namespace Common.BehaviourTrees
{
    public interface BT_IDecorator
    {
        BT_EStatus Execute(BT_ITask node);
    }
}
