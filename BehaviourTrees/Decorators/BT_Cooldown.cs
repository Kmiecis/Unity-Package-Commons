using Common.Extensions;
using UnityEngine;
using Random = System.Random;

namespace Common.BehaviourTrees
{
    public class BT_Cooldown : BT_ADecorator
    {
        private readonly Random _random = new Random();
        private readonly float _cooldown;
        private readonly float _deviation;
        private readonly bool _unscaled;

        private float _timestamp = 0.0f;

        public BT_Cooldown(float cooldown, float deviation = 0.0f, bool unscaled = false) :
            base("Cooldown")
        {
            _cooldown = cooldown;
            _deviation = deviation;
            _unscaled = unscaled;
        }

        private float Nowstamp
        {
            get => _unscaled ? Time.unscaledTime : Time.time;
        }

        public float Remaining
        {
            get => _cooldown - (Nowstamp - _timestamp);
        }

        protected override BT_EStatus OnUpdate(BT_ITask node)
        {
            if (Remaining > 0.0f)
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
                _timestamp = Nowstamp + _random.NextFloat(-_deviation, +_deviation);
            }
        }
    }
}
