namespace Common.BehaviourTrees
{
    /// <summary>
    /// <see cref="BT_ACompositeNode"/> which executes its child tasks sequentially until one fails or all succeeds, for which it succeeds
    /// </summary>
    public sealed class BT_SequenceNode : BT_ACompositeNode
    {
        public BT_SequenceNode(string name = "Sequence") :
            base(name)
        {
        }

        private void AbortRunningTask()
        {
            var current = CurrentTask;
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
    }
}
