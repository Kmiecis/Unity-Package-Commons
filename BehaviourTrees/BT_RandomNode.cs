using System;

namespace Common.BehaviourTrees
{
    public class BT_RandomNode : BT_ACompositeNode
    {
        private readonly Random _random;

        public BT_RandomNode() :
            base("Random")
        {
            _random = new Random();
        }

        protected override void OnStart()
        {
            base.OnStart();

            _current = _random.Next(0, _nodes.Length);
        }

        protected override BT_EStatus OnUpdate()
        {
            var current = CurrentTask;
            return current.WrappedExecute();
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

        public override void Abort()
        {
            base.Abort();

            AbortRunningTask();
        }
    }
}
