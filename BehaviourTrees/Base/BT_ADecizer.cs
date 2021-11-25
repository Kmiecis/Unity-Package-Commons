namespace Common.BehaviourTrees
{
    /// <summary>
    /// Makes decision whether execute a task and return its modified result or not execute it and return a predefined result
    /// </summary>
    public abstract class BT_ADecizer : BT_IDecizer
    {
        protected string _name;
        protected bool _started;

        public BT_ADecizer(string name = null)
        {
            _name = name ?? GetType().Name;
        }

        public string Name
        {
            get => _name;
        }

        protected abstract bool CanExecute();

        protected abstract BT_EStatus Decorate(BT_EStatus status);
        
        public BT_EStatus Execute(BT_ITask node)
        {
            if (!_started)
            {
                OnStart();
            }

            if (node.Status == BT_EStatus.Running)
            {
                if (!CanExecute())
                {
                    node.Abort();

                    OnFinish(BT_EStatus.Aborted);

                    return BT_EStatus.Aborted;
                }
            }
            else
            {
                if (!CanExecute())
                {
                    OnFinish(BT_EStatus.Failure);

                    return BT_EStatus.Failure;
                }
            }

            var result = node.Execute();

            var decorated = Decorate(result);

            if (
                result == BT_EStatus.Running &&
                decorated != BT_EStatus.Running
            )
            {
                node.Abort();

                result = BT_EStatus.Aborted;
            }
            
            if (result != BT_EStatus.Running)
            {
                OnFinish(result);
            }

            return decorated;
        }

        protected virtual void OnStart()
        {
            _started = true;
        }
        
        protected virtual void OnFinish(BT_EStatus result)
        {
            _started = false;
        }
    }
}
