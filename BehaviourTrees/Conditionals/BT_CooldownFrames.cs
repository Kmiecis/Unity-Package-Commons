using System;
using UnityEngine;
using Random = System.Random;

namespace Common.BehaviourTrees
{
    /// <summary>
    /// <see cref="BT_AConditional"/> which prevents a task execution until a certain amount of frames passes
    /// </summary>
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

        private int Nowstamp
        {
            get => Time.frameCount;
        }

        public int Remaining
        {
            get => _cooldown - (Nowstamp - _framestamp);
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
                _framestamp = Nowstamp + _random.Next(-_deviation, +_deviation);
            }
        }

        public override string ToString()
        {
            var remaining = Math.Max(Remaining, 0);
            return base.ToString() + " [" + remaining.ToString() + ']';
        }
    }
}
