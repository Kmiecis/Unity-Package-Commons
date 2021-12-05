namespace Common.BehaviourTrees
{
    /// <summary>
    /// <see cref="BT_ACompositeNode"/> which executes its child tasks in parallel until one succeed or all fail
    /// </summary>
    public sealed class BT_RaceNode : BT_ACompositeNode
    {
        private bool _ran;

        public BT_RaceNode(string name = "Race") :
            base(name)
        {
        }

        private void AbortRunningTasks()
        {
            for (int i = _current; i < _tasks.Length; ++i)
            {
                var current = _tasks[i];
                if (current.Status == BT_EStatus.Running)
                {
                    current.Abort();
                }
            }
        }

        protected override void OnStart()
        {
            base.OnStart();

            _ran = false;
        }

        protected override BT_EStatus OnUpdate()
        {
            var status = BT_EStatus.Failure;

            for (int i = _current; i < _tasks.Length; ++i)
            {
                var current = _tasks[i];
                if (
                    current.Status == BT_EStatus.Running ||
                    !_ran
                )
                {
                    var result = current.Execute();

                    switch (result)
                    {
                        case BT_EStatus.Failure:
                            if (_current == i)
                            {
                                _current += 1;
                            }
                            break;

                        case BT_EStatus.Success:
                            status = BT_EStatus.Success;
                            break;

                        case BT_EStatus.Running:
                            if (status != BT_EStatus.Success)
                            {
                                status = BT_EStatus.Running;
                            }
                            break;
                    }
                }
            }

            _ran = true;

            return status;
        }

        protected override void OnFinish(BT_EStatus status)
        {
            base.OnFinish(status);

            AbortRunningTasks();
        }

        public override string ToString()
        {
            return "race " + base.ToString();
        }
    }
}
