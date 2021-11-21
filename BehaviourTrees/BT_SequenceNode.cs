namespace Common.BehaviourTrees
{
    public class BT_SequenceNode : BT_ACompositeNode
    {
        private int _current;

        public BT_SequenceNode() :
            base("Sequence")
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

                if (result != BT_EStatus.Success)
                {
                    return result;
                }
            }

            return BT_EStatus.Success;
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
