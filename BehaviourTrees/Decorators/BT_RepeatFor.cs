using System;

namespace Common.BehaviourTrees
{
    /// <summary>
    /// <see cref="BT_ADecorator"/> which repeats a task for a certain amount of time
    /// </summary>
    public sealed class BT_RepeatFor : BT_ADecorator
    {
        private readonly float _duration;
        private readonly bool _unscaled;

        private float _timestamp;

        public BT_RepeatFor(float duration, bool unscaled = false) :
            base("RepeatFor")
        {
            _duration = duration;
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

        protected override void OnStart()
        {
            base.OnStart();

            Remaining = _duration;
        }

        public override BT_EStatus Decorate(BT_EStatus status)
        {
            if (status == BT_EStatus.Success)
            {
                if (Remaining > 0.0f)
                {
                    return BT_EStatus.Running;
                }
                return BT_EStatus.Success;
            }

            return status;
        }

        public override string ToString()
        {
            var remaining = Math.Max(Remaining, 0.0f).ToString("F1");
            return base.ToString() + " [" + remaining + ']';
        }
    }
}
