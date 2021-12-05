﻿namespace Common.BehaviourTrees
{
    /// <summary>
    /// <see cref="BT_ATask"/> node with a multiple child tasks support, usually used as a base for a certain execution flow
    /// </summary>
    public abstract class BT_ACompositeNode : BT_ATask
    {
        protected int _current;
        protected BT_ITask[] _tasks;

        public BT_ACompositeNode(string name = null) :
            base(name)
        {
        }

        public BT_ITask CurrentTask
        {
            get => _tasks[_current];
        }

        public virtual BT_ITask[] Tasks
        {
            get => _tasks;
            set => _tasks = value;
        }

        public virtual BT_ITask Task
        {
            get => _tasks[0];
            set => _tasks = new BT_ITask[] { value };
        }

        protected override void OnStart()
        {
            base.OnStart();

            _current = 0;
        }
    }
}
