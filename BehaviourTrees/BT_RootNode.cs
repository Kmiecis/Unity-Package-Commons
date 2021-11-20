namespace Common.BehaviourTrees
{
    public class BT_RootNode : BT_ATask
    {
        private BT_ITask _node;

        public BT_RootNode() :
            base("Root")
        {
        }

        protected override BT_EStatus OnUpdate()
        {
            return _node.WrappedExecute();
        }

        public BT_ITask Node
        {
            get => _node;
            set => _node = value;
        }
    }
}
