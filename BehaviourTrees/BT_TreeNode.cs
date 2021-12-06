namespace Common.BehaviourTrees
{
    /// <summary>
    /// <see cref="BT_ATask"/> node with a single child task support, usually used as a root of a certain branch
    /// </summary>
    public sealed class BT_TreeNode : BT_ATask
    {
        private BT_ITask _task;

        public BT_TreeNode(string name = "Root") :
            base(name)
        {
        }

        public BT_ITask Task
        {
            get => _task;
            set => _task = value;
        }

        private void AbortTask()
        {
            if (_task != null)
            {
                _task.Abort();
            }
        }
        
        protected override BT_EStatus OnUpdate()
        {
            return _task.Execute();
        }

        protected override void OnFinish(BT_EStatus status)
        {
            base.OnFinish(status);

            AbortTask();
        }
    }
}
