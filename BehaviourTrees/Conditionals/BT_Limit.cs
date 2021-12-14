using Common.Extensions;
using System;
using Random = System.Random;

namespace Common.BehaviourTrees
{
    /// <summary>
    /// <see cref="BT_AConditional"/> which halts a task execution after a certain amount of time passes
    /// </summary>
    public sealed class BT_Limit : BT_AConditional
    {
        private readonly Random _random = new Random();
        private readonly float _limit;
        private readonly float _deviation;
        private readonly bool _unscaled;

        private float _timestamp = 0.0f;

        public BT_Limit(float limit, float deviation = 0.0f, bool unscaled = false) :
            base("Limit")
        {
            _limit = limit;
            _deviation = deviation;
            _unscaled = unscaled;
        }

        private float Nowstamp
        {
            get => TimeUtility.GetTime(_unscaled);
        }

        public float Remaining
        {
            get => _timestamp - Nowstamp;
            set => _timestamp = Nowstamp + value;
        }

        public override bool CanExecute()
        {
            return Remaining > 0.0f;
        }

        protected override void OnStart()
        {
            base.OnStart();

            Remaining = _limit + _random.NextFloat(-_deviation, +_deviation);
        }

        public override string ToString()
        {
            var remaining = Math.Max(Remaining, 0.0f).ToString("F1");
            return base.ToString() + " [" + remaining + ']';
        }
    }
}
