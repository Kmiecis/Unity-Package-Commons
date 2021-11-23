﻿using UnityEngine;
using Random = System.Random;

namespace Common.BehaviourTrees
{
    public class BT_LimitFrames : BT_AConditional
    {
        private readonly Random _random = new Random();
        private readonly int _limit;
        private readonly int _deviation;

        private int _framestamp = 0;

        public BT_LimitFrames(int limit, int deviation = 0) :
            base("Limit")
        {
            _limit = limit;
            _deviation = deviation;
        }
        
        public int Remaining
        {
            get => _framestamp - Time.frameCount;
        }

        protected override bool CanExecute()
        {
            return Remaining > 0;
        }

        protected override void OnStart()
        {
            base.OnStart();

            _framestamp = Time.frameCount + _limit + _random.Next(-_deviation, +_deviation);
        }
    }
}
