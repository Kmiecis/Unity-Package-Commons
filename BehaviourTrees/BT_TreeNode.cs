namespace Common.BehaviourTrees
{
    public class BT_TreeNode : BT_ATask
    {
        private BT_ITask _node;

        public BT_TreeNode(string name = "Root") :
            base(name)
        {
        }

        public BT_ITask Node
        {
            get => _node;
            set => _node = value;
        }

        protected override BT_EStatus OnUpdate()
        {
            return _node.WrappedExecute();
        }

        public override void Abort()
        {
            base.Abort();

            _node.Abort();
        }
    }
}
