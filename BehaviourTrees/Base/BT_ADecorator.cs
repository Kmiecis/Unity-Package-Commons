namespace Common.BehaviourTrees
{
    public abstract class BT_ADecorator : BT_IDecorator
    {
        protected string _name;
        protected bool _started;

        public BT_ADecorator(string name = null)
        {
            _name = name ?? GetType().Name;
        }

        public string Name
        {
            get => _name;
        }

        public abstract BT_EStatus Decorate(BT_EStatus status);

        public void Start()
        {
            if (!_started)
            {
                OnStart();
                _started = true;
            }
        }

        public void Finish(BT_EStatus status)
        {
            if (_started)
            {
                OnFinish(status);
                _started = false;
            }
        }

        protected virtual void OnStart()
        {
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
