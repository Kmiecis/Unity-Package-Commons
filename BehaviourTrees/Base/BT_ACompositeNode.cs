namespace Common.BehaviourTrees
{
    public abstract class BT_ACompositeNode : BT_ATask
    {
        protected int _current;
        protected BT_ITask[] _nodes;

        public BT_ACompositeNode(string name = null) :
            base(name)
        {
        }

        public BT_ITask CurrentTask
        {
            get => _nodes[_current];
        }

        protected override void OnStart()
        {
            base.OnStart();

            _current = 0;
        }

        public virtual BT_ITask[] Nodes
        {
            get => _nodes;
            set => _nodes = value;
        }
    }
}
