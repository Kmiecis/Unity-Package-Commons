using Common.Extensions;
using UnityEngine;
using Random = System.Random;

namespace Common.BehaviourTrees
{
    public class BT_Cooldown : BT_AConditional
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

        protected override bool CanExecute()
        {
            return Remaining <= 0.0f;
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
