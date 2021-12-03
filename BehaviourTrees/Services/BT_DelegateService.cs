namespace Common.BehaviourTrees
{
    /// <summary>
    /// <see cref="BT_AService"/> with custom delegate support
    /// </summary>
    public class BT_DelegateService : BT_AService
    {
        public delegate void OnUpdateDelegate();

        private OnUpdateDelegate _onUpdate;

        public BT_DelegateService(string name = "Delegate") :
            base(name)
        {
        }

        public OnUpdateDelegate OnUpdateAction
        {
            set => _onUpdate = value;
        }

        protected override void OnUpdate()
        {
            _onUpdate?.Invoke();
        }
    }
}
