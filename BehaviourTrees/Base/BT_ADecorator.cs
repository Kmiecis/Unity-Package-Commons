namespace Common.BehaviourTrees
{
    public abstract class BT_ADecorator : BT_IDecorator
    {
        private bool _started;

        protected string _name;

        public BT_ADecorator(string name = null)
        {
            _name = name ?? GetType().Name;
        }

        public BT_EStatus Execute(BT_ITask node)
        {
            if (!_started)
            {
                OnStart();
                _started = true;
            }

            var result = OnUpdate(node);

            if (result != BT_EStatus.Running)
            {
                OnFinish(result);
                _started = false;
            }

            return result;
        }

        protected virtual void OnStart()
        {
        }

        protected virtual BT_EStatus OnUpdate(BT_ITask node)
        {
            return node.Execute();
        }

        protected virtual void OnFinish(BT_EStatus result)
        {
        }
    }
}
