using Common.Extensions;
using UnityEngine;
using Random = System.Random;

namespace Common.BehaviourTrees
{
    public class BT_Cooldown : BT_ADecorator
    {
        private readonly Random _random;
        private readonly float _cooldown;
        private readonly float _deviation;

        private float _timestamp = 0.0f;

        public BT_Cooldown(float cooldown, float deviation = 0.0f) :
            base("Cooldown")
        {
            _random = new Random();
            _cooldown = cooldown;
            _deviation = deviation;
        }

        public float Remaining
        {
            get => _cooldown - (Time.time - _timestamp);
        }

        protected override BT_EStatus OnUpdate(BT_ITask node)
        {
            if (Remaining > 0.0f)
            {
                return BT_EStatus.Failure;
            }

            return node.Execute();
        }

        protected override void OnFinish(BT_EStatus result)
        {
            if (result != BT_EStatus.Failure)
            {
                var nowTime = Time.time;
                var newDeviation = _random.NextFloat(-_deviation, +_deviation);
                _timestamp = nowTime + newDeviation;
            }
        }
    }
}
