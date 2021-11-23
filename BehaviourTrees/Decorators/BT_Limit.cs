using Common.Extensions;
using UnityEngine;
using Random = System.Random;

namespace Common.BehaviourTrees
{
    public class BT_Limit : BT_ADecorator
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
            get => _unscaled ? Time.unscaledTime : Time.time;
        }

        public float Remaining
        {
            get => _timestamp - Nowstamp;
        }

        protected override void OnStart()
        {
            base.OnStart();

            _timestamp = Nowstamp + _limit + _random.NextFloat(-_deviation, +_deviation);
        }

        protected override BT_EStatus OnUpdate(BT_ITask node)
        {
            if (Remaining > 0.0f)
            {
                return base.OnUpdate(node);
            }
            return BT_EStatus.Failure;
        }
    }
}
