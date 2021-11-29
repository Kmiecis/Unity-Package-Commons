namespace Common.BehaviourTrees
{
    public abstract class BT_AConditional : BT_IConditional
    {
        protected string _name;
        protected bool _started;

        public BT_AConditional(string name = null)
        {
            _name = name ?? GetType().Name;
        }

        public string Name
        {
            get => _name;
        }

        public void Start()
        {
            if (!_started)
            {
                OnStart();
                _started = true;
            }
        }

        public abstract bool CanExecute();

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

    public abstract class BT_AConditional<T> : BT_AConditional
    {
        protected readonly T _context;

        public BT_AConditional(T context, string name = null) :
            base(name)
        {
            _context = context;
        }
    }
}
