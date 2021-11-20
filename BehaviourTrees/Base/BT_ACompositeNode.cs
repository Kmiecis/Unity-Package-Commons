namespace Common.BehaviourTrees
{
    public abstract class BT_ACompositeNode : BT_ATask
    {
        protected BT_ITask[] _nodes;

        public BT_ACompositeNode(string name = null) :
            base(name)
        {
        }

        public virtual BT_ITask[] Nodes
        {
            get => _nodes;
            set => _nodes = value;
        }
    }
}
