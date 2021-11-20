namespace Common.StateMachine
{
    public interface SM_IState
    {
        void OnStart();

        void OnUpdate();

        void OnFinish();
    }
}
