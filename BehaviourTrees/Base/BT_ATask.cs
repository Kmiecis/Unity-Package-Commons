namespace Common.BehaviourTrees
{
    /// <summary>
    /// Base <see cref="BT_ITask"/> implementation
    /// </summary>
    public abstract class BT_ATask : BT_ITask
    {
        protected string _name;
        protected BT_EStatus _status;

        protected BT_IConditional[] _conditionals;
        protected BT_IDecorator[] _decorators;
        protected BT_IService[] _services;

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

        public BT_IService[] Services
        {
            set => _services = value;
        }

        public BT_IService Service
        {
            set => _services = new BT_IService[] { value };
        }

        #region CONDITIONALS
        protected void StartConditionals()
        {
            if (_conditionals != null)
            {
                for (int i = 0; i < _conditionals.Length; ++i)
                {
                    _conditionals[i].Start();
                }
            }
        }

        protected bool CanExecute()
        {
            if (_conditionals != null)
            {
                for (int i = 0; i < _conditionals.Length; ++i)
                {
                    if (!_conditionals[i].CanExecute())
                    {
                        return false;
                    }
                }
            }
            return true;
        }

        protected void FinishConditionals(BT_EStatus status)
        {
            if (_conditionals != null)
            {
                for (int i = 0; i < _conditionals.Length; ++i)
                {
                    _conditionals[i].Finish(status);
                }
            }
        }
        #endregion

        #region DECORATORS
        protected void StartDecorators()
        {
            if (_decorators != null)
            {
                for (int i = 0; i < _decorators.Length; ++i)
                {
                    _decorators[i].Start();
                }
            }
        }

        protected BT_EStatus Decorate(BT_EStatus status)
        {
            if (_decorators != null)
            {
                for (int i = 0; i < _decorators.Length; ++i)
                {
                    status = _decorators[i].Decorate(status);
                }
            }
            return status;
        }

        protected void FinishDecorators(BT_EStatus status)
        {
            if (_decorators != null)
            {
                for (int i = 0; i < _decorators.Length; ++i)
                {
                    _decorators[i].Finish(status);
                }
            }
        }
        #endregion

        #region SERVICES
        protected void ExecuteServices()
        {
            if (_services != null)
            {
                for (int i = 0; i < _services.Length; ++i)
                {
                    _services[i].Execute();
                }
            }
        }
        #endregion

        public BT_EStatus Execute()
        {
            ExecuteServices();

            if (_status != BT_EStatus.Running)
            {
                StartConditionals();

                if (!CanExecute())
                {
                    _status = BT_EStatus.Failure;

                    FinishConditionals(_status);

                    return _status;
                }

                StartDecorators();

                OnStart();
            }
            else
            {
                if (!CanExecute())
                {
                    OnFinish(BT_EStatus.Failure);

                    FinishConditionals(_status);
                    FinishDecorators(_status);

                    return _status;
                }
            }

            var result = OnUpdate();
            
            var decorated = Decorate(result);

            if (
                result == BT_EStatus.Running &&
                decorated != BT_EStatus.Running
            )
            {
                result = BT_EStatus.Failure;
            }

            if (result != BT_EStatus.Running)
            {
                OnFinish(result);

                FinishConditionals(_status);
                FinishDecorators(_status);
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
        }

        public void Abort()
        {
            OnFinish(BT_EStatus.Failure);
        }

        public override string ToString()
        {
            return _name;
        }
    }

    /// <summary>
    /// <see cref="BT_ATask"/> implementation with build-in context <see cref="T"/> support of any type
    /// </summary>
    public abstract class BT_ATask<T> : BT_ATask
    {
        protected readonly T _context;

        public BT_ATask(T context, string name = null) :
            base(name)
        {
            _context = context;
        }
    }
}
