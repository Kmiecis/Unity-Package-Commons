﻿using System;
using UnityEngine;
using Random = System.Random;

namespace Common.BehaviourTrees
{
    /// <summary>
    /// <see cref="BT_AConditional"/> which halts a task execution after a certain amount of frames passes
    /// </summary>
    public sealed class BT_LimitFrames : BT_AConditional
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

        private int Nowstamp
        {
            get => Time.frameCount;
        }
        
        public int Remaining
        {
            get => _framestamp - Nowstamp;
        }

        public override bool CanExecute()
        {
            return Remaining > 0;
        }

        protected override void OnStart()
        {
            base.OnStart();

            _framestamp = Nowstamp + _limit + _random.Next(-_deviation, +_deviation);
        }

        public override string ToString()
        {
            var remaining = Math.Max(Remaining, 0);
            return base.ToString() + " [" + remaining.ToString() + ']';
        }
    }
}
