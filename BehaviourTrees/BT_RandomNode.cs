using System;

namespace Common.BehaviourTrees
{
    /// <summary>
    /// <see cref="BT_ACompositeNode"/> which executes a random child task until it is no longer running and uses its result
    /// </summary>
    public sealed class BT_RandomNode : BT_ACompositeNode
    {
        private readonly Random _random;

        public BT_RandomNode(string name = "Random") :
            base(name)
        {
            _random = new Random();
        }

        private void AbortRunningTask()
        {
            var current = CurrentTask;
            if (current.Status == BT_EStatus.Running)
            {
                current.Abort();
            }
        }

        protected override void OnStart()
        {
            base.OnStart();

            _current = _random.Next(0, _tasks.Length);
        }

        protected override BT_EStatus OnUpdate()
        {
            var current = CurrentTask;
            return current.Execute();
        }

        protected override void OnFinish(BT_EStatus status)
        {
            base.OnFinish(status);

            AbortRunningTask();
        }
    }
}
