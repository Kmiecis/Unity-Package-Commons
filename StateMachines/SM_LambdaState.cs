using System;

namespace Common.StateMachines
{
    public sealed class SM_LambdaState : SM_AState
    {
        public delegate void OnStartDelegate();
        public delegate Type OnUpdateDelegate();
        public delegate void OnFinishDelegate();

        private OnStartDelegate _onStart;
        private OnUpdateDelegate _onUpdate;
        private OnFinishDelegate _onFinish;

        public SM_LambdaState(string name = "Lambda") :
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

        protected override Type OnUpdate()
        {
            if (_onUpdate != null)
            {
                return _onUpdate();
            }
            return base.OnUpdate();
        }

        protected override void OnFinish()
        {
            base.OnFinish();

            _onFinish?.Invoke();
        }
    }
}
