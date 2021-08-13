using System;

namespace Common.BehaviourTree
{
    public class RandomSelectorNode : SelectorNode
    {
        protected Random _random;

        public RandomSelectorNode(int seed = 0)
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
