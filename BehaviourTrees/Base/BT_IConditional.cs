namespace Common.BehaviourTrees
{
    public interface BT_IConditional
    {
        void Start();

        bool CanExecute();

        void Finish(BT_EStatus status);
    }
}
