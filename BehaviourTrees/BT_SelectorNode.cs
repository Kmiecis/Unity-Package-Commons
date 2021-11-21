namespace Common.BehaviourTrees
{
    public class BT_SelectorNode : BT_ACompositeNode
    {
        private int _current;

        public BT_SelectorNode() :
            base("Selector")
        {
        }

        protected override void OnStart()
        {
            base.OnStart();

            _current = 0;
        }

        protected override BT_EStatus OnUpdate()
        {
            for (; _current < _nodes.Length; ++_current)
            {
                var result = _nodes[_current].DecoratedExecute();

                if (result != BT_EStatus.Failure)
                {
                    return result;
                }
            }

            return BT_EStatus.Failure;
        }

        private void AbortCurrentNode()
        {
            _nodes[_current].Abort();
        }

        public override void Abort()
        {
            base.Abort();

            AbortCurrentNode();
        }
    }
}
