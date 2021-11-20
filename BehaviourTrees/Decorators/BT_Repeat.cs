﻿namespace Common.BehaviourTrees
{
    public class BT_Repeat : BT_ADecorator
    {
        private readonly int _repeats;

        private int _remaining;

        public BT_Repeat(int repeats = -1) :
            base("Repeat")
        {
            _repeats = repeats;
            _remaining = repeats;
        }

        protected override void OnStart()
        {
            _remaining = _repeats;
        }

        protected override BT_EStatus OnUpdate(BT_ITask node)
        {
            var result = node.Execute();

            if (result == BT_EStatus.Success)
            {
                _remaining -= 1;
                if (_remaining == 0)
                {
                    return BT_EStatus.Success;
                }
                return BT_EStatus.Running;
            }

            return result;
        }
    }
}