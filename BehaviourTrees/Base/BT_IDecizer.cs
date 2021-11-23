namespace Common.BehaviourTrees
{
    public interface BT_IDecizer
    {
        BT_EStatus Execute(BT_ITask node);
    }
}
