namespace Common.BehaviourTrees
{
    public interface BT_IDecorator
    {
        void Start();

        BT_EStatus Decorate(BT_EStatus status);

        void Finish(BT_EStatus status);
    }
}
