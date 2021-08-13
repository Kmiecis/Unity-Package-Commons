namespace Common.BehaviourTree
{
    public class ParallelNode : ACompositeNode
    {
        protected int _successThreshold;
        protected int _failThreshold;

        public ParallelNode(int successThreshold, int failThreshold)
        {
            _successThreshold = successThreshold;
            _failThreshold = failThreshold;
        }

        public override ENodeState Evaluate()
        {
            int successCount = 0;
            int failCount = 0;

            foreach (var node in _nodes)
            {
                var status = node.Evaluate();

                switch (status)
                {
                    case ENodeState.Success:
                        ++successCount;
                        break;

                    case ENodeState.Failure:
                        ++failCount;
                        break;
                }
            }

            if (_successThreshold > 0 && successCount >= _successThreshold)
            {
                return ENodeState.Success;
            }

            if (_failThreshold > 0 && failCount >= _failThreshold)
            {
                return ENodeState.Failure;
            }

            return ENodeState.Running;
        }
    }
}
