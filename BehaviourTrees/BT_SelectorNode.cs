namespace Common.BehaviourTrees
{
    public class BT_SelectorNode : BT_ACompositeNode
    {
        public BT_SelectorNode() :
            base("Selector")
        {
        }

        protected override BT_EStatus OnUpdate()
        {
            for (; _current < _nodes.Length; ++_current)
            {
                var result = _nodes[_current].WrappedExecute();

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

        private void AbortRunningTask()
        {
            var current = _nodes[_current];
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
