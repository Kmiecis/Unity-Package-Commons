using Common.Extensions;
using System;

namespace Common.BehaviourTree
{
    public class RandomSequenceNode : SequenceNode
    {
        protected Random _random;

        public RandomSequenceNode(int seed = 0)
        {
            _random = new Random(seed);
        }

        public override ENodeState Evaluate()
        {
            _random.Shuffle(_nodes);
            return base.Evaluate();
        }
    }
}
