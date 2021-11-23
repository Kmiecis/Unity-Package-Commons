namespace Common.BehaviourTrees
{
    public abstract class BT_ATask : BT_ITask
    {
        protected string _name;
        protected BT_EStatus _status;
        protected BT_IDecizer _decizer;

        public BT_ATask(string name = null)
        {
            _name = name ?? GetType().Name;
        }

        public string Name
        {
            get => _name;
        }

        public BT_EStatus Status
        {
            get => _status;
        }

        public virtual BT_IDecizer Decizer
        {
            get => _decizer;
            set => _decizer = value;
        }

        public BT_EStatus Execute()
        {
            if (_status != BT_EStatus.Running)
            {
                OnStart();
            }

            var result = OnUpdate();

            if (result != BT_EStatus.Running)
            {
                OnFinish(result);
            }

            return result;
        }
        
        protected virtual void OnStart()
        {
            _status = BT_EStatus.Running;
        }

        protected abstract BT_EStatus OnUpdate();

        protected virtual void OnFinish(BT_EStatus status)
        {
            _status = status;
        }

        public virtual void Abort()
        {
            OnFinish(BT_EStatus.Aborted);
        }

        public override string ToString()
        {
            return _name;
        }
    }
}
