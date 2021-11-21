using Common.Extensions;
using UnityEngine;
using Random = System.Random;

namespace Common.BehaviourTrees
{
    public class BT_Wait : BT_ATask
    {
        private readonly Random _random;
        private readonly float _duration;
        private readonly float _deviation;

        private float _timestamp = 0.0f;

        public BT_Wait(float duration, float deviation = 0.0f) :
            base("Wait")
        {
            _random = new Random();
            _duration = duration;
            _deviation = deviation;
        }

        public float Remaining
        {
            get => _timestamp - Time.time;
        }
        
        protected override void OnStart()
        {
            base.OnStart();

            var nowTime = Time.time;
            var newDeviation = _random.NextFloat(-_deviation, +_deviation);
            _timestamp = nowTime + _duration + newDeviation;
        }

        protected override BT_EStatus OnUpdate()
        {
            if (Remaining <= 0.0f)
            {
                return BT_EStatus.Success;
            }
            return BT_EStatus.Running;
        }
    }
}
