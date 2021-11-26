namespace Common.BehaviourTrees
{
    public class BT_SequenceNode : BT_ACompositeNode
    {
        public BT_SequenceNode() :
            base("Sequence")
        {
        }

        protected override BT_EStatus OnUpdate()
        {
            for (; _current < _tasks.Length; ++_current)
            {
                var result = _tasks[_current].Execute();

                if (result != BT_EStatus.Success)
                {
                    return result;
                }
            }

            _current -= 1;
            return BT_EStatus.Success;
        }

        protected override void OnFinish(BT_EStatus status)
        {
            base.OnFinish(status);

            AbortRunningTask();
        }

        private void AbortRunningTask()
        {
            var current = CurrentTask;
            if (current.Status == BT_EStatus.Running)
            {
                current.Abort();
            }
        }
    }
}
