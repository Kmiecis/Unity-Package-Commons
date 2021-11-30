namespace Common.BehaviourTrees
{
    public sealed class BT_SelectorNode : BT_ACompositeNode
    {
        public BT_SelectorNode(string name = "Selector") :
            base(name)
        {
        }

        private void AbortRunningTask()
        {
            var current = _tasks[_current];
            if (current.Status == BT_EStatus.Running)
            {
                current.Abort();
            }
        }

        protected override BT_EStatus OnUpdate()
        {
            for (; _current < _tasks.Length; ++_current)
            {
                var result = _tasks[_current].Execute();

                if (result != BT_EStatus.Failure)
                {
                    return result;
                }
            }

            _current -= 1;
            return BT_EStatus.Failure;
        }

        protected override void OnFinish(BT_EStatus status)
        {
            base.OnFinish(status);

            AbortRunningTask();
        }
    }
}
