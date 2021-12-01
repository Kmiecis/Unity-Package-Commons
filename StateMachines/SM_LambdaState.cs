using System;

namespace Common.StateMachines
{
    public sealed class SM_LambdaState : SM_AState
    {
        private Action _onStart;
        private Func<Type> _onUpdate;
        private Action _onFinish;

        public SM_LambdaState(string name = "Lambda") :
            base(name)
        {
        }

        public Action OnStartCall
        {
            set => _onStart = value;
        }

        public Func<Type> OnUpdateCall
        {
            set => _onUpdate = value;
        }

        public Action OnFinishCall
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
