using System;
using UnityEngine;
using Random = System.Random;

namespace Common.BehaviourTrees
{
    /// <summary>
    /// <see cref="BT_ATask"/> which executes for a certain number of frames
    /// </summary>
    public sealed class BT_WaitFrames : BT_ATask
    {
        private readonly Random _random;
        private readonly int _count;
        private readonly int _deviation;

        private int _framestamp = 0;

        public BT_WaitFrames(int count, int deviation = 0) :
            base("WaitFrames")
        {
            _random = new Random();
            _count = count;
            _deviation = deviation;
        }

        private int Nowstamp
        {
            get => Time.frameCount;
        }

        public int Remaining
        {
            get => _framestamp - Nowstamp;
        }

        protected override void OnStart()
        {
            base.OnStart();

            _framestamp = Nowstamp + _count + _random.Next(-_deviation, +_deviation);
        }

        protected override BT_EStatus OnUpdate()
        {
            if (Remaining > 0)
            {
                return BT_EStatus.Running;
            }
            return BT_EStatus.Success;
        }

        public override string ToString()
        {
            var remaining = Math.Max(Remaining, 0);
            return base.ToString() + " [" + remaining.ToString() + ']';
        }
    }
}
