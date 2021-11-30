using System;

namespace Common.BehaviourTrees
{
    public sealed class BT_LambdaTask : BT_ATask
    {
        private Action _onStart;
        private Func<BT_EStatus> _onUpdate;
        private Action<BT_EStatus> _onFinish;

        public BT_LambdaTask(string name = "Lambda") :
            base(name)
        {
        }

        public Action OnStartCall
        {
            set => _onStart = value;
        }

        public Func<BT_EStatus> OnUpdateCall
        {
            set => _onUpdate = value;
        }

        public Action<BT_EStatus> OnFinishCall
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
