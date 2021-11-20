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
            _current = 0;
        }

        protected override BT_EStatus OnUpdate()
        {
            for (int i = _current; i < _nodes.Length; ++i)
            {
                var result = _nodes[i].WrappedExecute();

                switch (result)
                {
                    case BT_EStatus.Failure:
                        // Skip to next
                        break;

                    case BT_EStatus.Success:
                        return BT_EStatus.Success;

                    case BT_EStatus.Running:
                        _current = i;
                        return BT_EStatus.Running;
                }
            }

            return BT_EStatus.Failure;
        }
    }
}
