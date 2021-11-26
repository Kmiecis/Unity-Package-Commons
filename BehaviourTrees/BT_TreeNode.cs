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
            return _node.Execute();
        }

        protected override void OnFinish(BT_EStatus status)
        {
            base.OnFinish(status);

            if (_node.Status == BT_EStatus.Running)
            {
                _node.Abort();
            }
        }
    }
}
