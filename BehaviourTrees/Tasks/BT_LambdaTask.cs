namespace Common.BehaviourTrees
{
    public sealed class BT_LambdaTask : BT_ATask
    {
        public delegate void OnStartDelegate();
        public delegate BT_EStatus OnUpdateDelegate();
        public delegate void OnFinishDelegate(BT_EStatus status);

        private OnStartDelegate _onStart;
        private OnUpdateDelegate _onUpdate;
        private OnFinishDelegate _onFinish;

        public BT_LambdaTask(string name = "Lambda") :
            base(name)
        {
        }

        public OnStartDelegate OnStartAction
        {
            set => _onStart = value;
        }

        public OnUpdateDelegate OnUpdateAction
        {
            set => _onUpdate = value;
        }

        public OnFinishDelegate OnFinishAction
        {
            set => _onFinish = value;
        }

        protected override void OnStart()
        {
            base.OnStart();

            _onStart?.Invoke();
        }

        protected override BT_EStatus OnUpdate()
        {
            if (_onUpdate != null)
            {
                return _onUpdate();
            }
            return BT_EStatus.Success;
        }

        protected override void OnFinish(BT_EStatus status)
        {
            base.OnFinish(status);

            _onFinish?.Invoke(status);
        }
    }
}
