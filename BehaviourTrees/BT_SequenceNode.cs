﻿namespace Common.BehaviourTrees
{
    /// <summary>
    /// <see cref="BT_ACompositeNode"/> which executes its child tasks in sequence until one fail or all succeed
    /// </summary>
    public sealed class BT_SequenceNode : BT_ACompositeNode
    {
        public BT_SequenceNode(string name = "") :
            base(name)
        {
        }
        
        protected override BT_EStatus OnUpdate()
        {
            for (; _current < _tasks.Length; ++_current)
            {
                var result = _tasks[_current].Execute();

                if (result != BT_EStatus.Success)
                {
                    return result;
                }
            }

            _current -= 1;
            return BT_EStatus.Success;
        }
    }
}
