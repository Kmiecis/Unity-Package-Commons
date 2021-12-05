using Common.Extensions;
using System;
using Random = System.Random;

namespace Common.BehaviourTrees
{
    /// <summary>
    /// <see cref="BT_AConditional"/> which prevents a task execution until a certain amount of time passes
    /// </summary>
    public sealed class BT_Cooldown : BT_AConditional
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
            get => TimeUtility.GetTime(_unscaled);
        }
        
        public float Remaining
        {
            get => _cooldown - (Nowstamp - _timestamp);
        }

        public override bool CanExecute()
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

        public override string ToString()
        {
            var remaining = Math.Max(Remaining, 0.0f);
            return base.ToString() + " [" + remaining.ToString("F1") + ']';
        }
    }
}
