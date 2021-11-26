namespace Common.BehaviourTrees
{
    public interface BT_ITask
    {
        BT_EStatus Status { get; }

        BT_EStatus Execute();

        void Abort();
    }
}
