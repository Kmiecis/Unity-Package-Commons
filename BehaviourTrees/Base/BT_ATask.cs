using Common.Extensions;
using System.Linq;

namespace Common.BehaviourTrees
{
    public abstract class BT_ATask : BT_ITask
    {
        protected string _name;
        protected BT_EStatus _status;

        protected BT_IConditional[] _conditionals;
        protected BT_IDecorator[] _decorators;

        public BT_ATask(string name = null)
        {
            _name = name ?? GetType().Name;
        }

        public string Name
        {
            get => _name;
        }

        public BT_EStatus Status
        {
            get => _status;
        }

        public BT_IConditional[] Conditionals
        {
            set => _conditionals = value;
        }

        public BT_IConditional Conditional
        {
            set => _conditionals = new BT_IConditional[] { value };
        }

        public BT_IDecorator[] Decorators
        {
            set => _decorators = value;
        }

        public BT_IDecorator Decorator
        {
            set => _decorators = new BT_IDecorator[] { value };
        }

        public BT_EStatus Execute()
        {
            if (_status != BT_EStatus.Running)
            {
                _conditionals?.ForEach(c => c.Start());

                if (!(_conditionals?.All(c => c.CanExecute())).GetValueOrDefault(true))
                {
                    _status = BT_EStatus.Failure;

                    _conditionals?.ForEach(c => c.Finish(_status));

                    return _status;
                }

                _decorators?.ForEach(d => d.Start());

                OnStart();
            }
            else
            {
                if (!(_conditionals?.All(c => c.CanExecute())).GetValueOrDefault(true))
                {
                    OnFinish(BT_EStatus.Aborted);

                    return _status;
                }
            }

            var result = OnUpdate();

            var decorated = result;
            _decorators?.ForEach(d => decorated = d.Decorate(decorated));

            if (
                result == BT_EStatus.Running &&
                decorated != BT_EStatus.Running
            )
            {
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
            _status = BT_EStatus.Running;
        }

        protected abstract BT_EStatus OnUpdate();

        protected virtual void OnFinish(BT_EStatus status)
        {
            _status = status;

            _conditionals?.ForEach(c => c.Finish(_status));
            _decorators?.ForEach(d => d.Finish(_status));
        }

        public void Abort()
        {
            OnFinish(BT_EStatus.Aborted);
        }

        public override string ToString()
        {
            return _name;
        }
    }
}
