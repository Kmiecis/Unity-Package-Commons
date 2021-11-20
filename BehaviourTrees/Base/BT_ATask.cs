namespace Common.BehaviourTrees
{
    public abstract class BT_ATask : BT_ITask
    {
        private bool _started;

        protected string _name;
        protected BT_IDecorator _decorator;

        public BT_ATask(string name = null)
        {
            _name = name ?? GetType().Name;
        }
        
        public BT_EStatus Execute()
        {
            if (!_started)
            {
                OnStart();
                _started = true;
            }

            var result = OnUpdate();

            if (result != BT_EStatus.Running)
            {
                OnFinish(result);
                _started = false;
            }

            return result;
        }

        public virtual BT_IDecorator Decorator
        {
            get => _decorator;
            set => _decorator = value;
        }
        
        protected virtual void OnStart()
        {
        }

        protected virtual BT_EStatus OnUpdate()
        {
            return BT_EStatus.Success;
        }

        protected virtual void OnFinish(BT_EStatus status)
        {
        }

        public override string ToString()
        {
            return _name;
        }
    }
}
