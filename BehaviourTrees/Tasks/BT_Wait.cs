using Common.Extensions;
using System;
using Random = System.Random;

namespace Common.BehaviourTrees
{
    /// <summary>
    /// <see cref="BT_ATask"/> which executes for a certain amount of time
    /// </summary>
    public sealed class BT_Wait : BT_ATask
    {
        private readonly Random _random = new Random();
        private readonly float _duration;
        private readonly float _deviation;
        private readonly bool _unscaled;

        private float _timestamp = 0.0f;

        public BT_Wait(float duration, float deviation = 0.0f, bool unscaled = false) :
            base("Wait")
        {
            _duration = duration;
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
        }
        
        protected override void OnStart()
        {
            base.OnStart();

            _timestamp = Nowstamp + _duration + _random.NextFloat(-_deviation, +_deviation);
        }

        protected override BT_EStatus OnUpdate()
        {
            if (Remaining > 0.0f)
            {
                return BT_EStatus.Running;
            }
            return BT_EStatus.Success;
        }

        public override string ToString()
        {
            var remaining = Math.Max(Remaining, 0.0f).ToString("F1");
            return base.ToString() + " [" + remaining + ']';
        }
    }
}
