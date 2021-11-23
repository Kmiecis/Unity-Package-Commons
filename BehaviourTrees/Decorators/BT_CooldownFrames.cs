using UnityEngine;
using Random = System.Random;

namespace Common.BehaviourTrees
{
    public class BT_CooldownFrames : BT_ADecorator
    {
        private readonly Random _random = new Random();
        private readonly int _cooldown;
        private readonly int _deviation;

        private int _framestamp = 0;

        public BT_CooldownFrames(int cooldown, int deviation = 0) :
            base("Cooldown")
        {
            _cooldown = cooldown;
            _deviation = deviation;
        }

        public int Remaining
        {
            get => _cooldown - (Time.frameCount - _framestamp);
        }

        protected override BT_EStatus OnUpdate(BT_ITask node)
        {
            if (Remaining > 0)
            {
                return BT_EStatus.Failure;
            }

            return base.OnUpdate(node);
        }

        protected override void OnFinish(BT_EStatus result)
        {
            base.OnFinish(result);

            if (result != BT_EStatus.Failure)
            {
                _framestamp = Time.frameCount + _random.Next(-_deviation, +_deviation);
            }
        }
    }
}
