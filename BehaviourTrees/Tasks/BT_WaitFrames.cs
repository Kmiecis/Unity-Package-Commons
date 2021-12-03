using UnityEngine;
using Random = System.Random;

namespace Common.BehaviourTrees
{
    /// <summary>
    /// <see cref="BT_ATask"/> which executes for a certain frames count
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

        public int Remaining
        {
            get => _framestamp - Time.frameCount;
        }

        protected override void OnStart()
        {
            base.OnStart();

            _framestamp = Time.frameCount + _count + _random.Next(-_deviation, +_deviation);
        }

        protected override BT_EStatus OnUpdate()
        {
            if (Remaining > 0)
            {
                return BT_EStatus.Running;
            }
            return BT_EStatus.Success;
        }
    }
}
