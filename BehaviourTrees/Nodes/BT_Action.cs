using System;

namespace Common.BehaviourTrees
{
    public class BT_Action : BT_ATask
    {
        private readonly Action _action;

        public BT_Action(Action action) :
            base("Action")
        {
            _action = action;
        }

        protected override void OnStart()
        {
            base.OnStart();
            _action();
        }
    }
}
