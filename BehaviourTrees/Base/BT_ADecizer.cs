﻿namespace Common.BehaviourTrees
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
        
        public BT_EStatus Execute(BT_ITask node)
        {
            if (!_started)
            {
                OnStart();
            }

            var result = OnUpdate(node);

            if (result != BT_EStatus.Running)
            {
                OnFinish(result);
            }

            return result;
        }

        protected virtual void OnStart()
        {
            _started = true;
        }

        protected virtual BT_EStatus OnUpdate(BT_ITask node)
        {
            return node.Execute();
        }

        protected virtual void OnFinish(BT_EStatus result)
        {
            _started = false;
        }
    }
}
