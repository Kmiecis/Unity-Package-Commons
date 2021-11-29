namespace Common.BehaviourTrees
{
    public abstract class BT_ACompositeNode : BT_ATask
    {
        protected int _current;
        protected BT_ITask[] _tasks;

        public BT_ACompositeNode(string name = null) :
            base(name)
        {
        }

        public BT_ITask CurrentTask
        {
            get => _tasks[_current];
        }

        public virtual BT_ITask[] Tasks
        {
            set => _tasks = value;
        }

        public virtual BT_ITask Task
        {
            set => _tasks = new BT_ITask[] { value };
        }

        protected override void OnStart()
        {
            base.OnStart();

            _current = 0;
        }
    }
}
