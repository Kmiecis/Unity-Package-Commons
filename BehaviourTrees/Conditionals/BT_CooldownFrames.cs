using UnityEngine;
using Random = System.Random;

namespace Common.BehaviourTrees
{
    public sealed class BT_CooldownFrames : BT_AConditional
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

        public override bool CanExecute()
        {
            return Remaining <= 0;
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
