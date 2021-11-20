using Common.Extensions;

namespace Common.BehaviourTrees
{
    public class BT_ParallelNode : BT_ACompositeNode
    {
        private int _current;
        private BT_EStatus[] _statuses;

        public BT_ParallelNode() :
            base("Parallel")
        {
        }

        protected override void OnStart()
        {
            _current = 0;
            _statuses.Populate(BT_EStatus.Running);
        }

        protected override BT_EStatus OnUpdate()
        {
            var status = BT_EStatus.Success;

            for (int i = _current; i < _nodes.Length; ++i)
            {
                if (_statuses[i] == BT_EStatus.Running)
                {
                    var result = _statuses[i] = _nodes[i].WrappedExecute();

                    switch (result)
                    {
                        case BT_EStatus.Failure:
                            status = BT_EStatus.Failure;
                            break;

                        case BT_EStatus.Success:
                            if (_current == i)
                            {
                                _current += 1;
                            }
                            break;

                        case BT_EStatus.Running:
                            if (status != BT_EStatus.Failure)
                            {
                                status = BT_EStatus.Running;
                            }
                            break;
                    }
                }
            }

            return status;
        }

        public override BT_ITask[] Nodes
        {
            get => base.Nodes;
            set
            {
                base.Nodes = value;
                _statuses = new BT_EStatus[value.Length];
            }
        }
    }
}
