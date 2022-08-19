using System;
using System.Collections;
using UnityEngine;

namespace Common
{
    public abstract class ACoroutineWrapper : IDisposable
    {
        protected readonly MonoBehaviour _target;

        protected Coroutine _coroutine;

        public ACoroutineWrapper(MonoBehaviour target)
        {
            _target = target;
        }

        public bool IsRunning
        {
            get => _coroutine != null;
        }

        public abstract void Start();

        public void Stop()
        {
            if (_coroutine != null)
            {
                _target.StopCoroutine(_coroutine);
                _coroutine = null;
            }
        }

        public void Dispose()
        {
            Stop();
        }
    }

    public class CoroutineWrapper : ACoroutineWrapper
    {
        private readonly Func<IEnumerator> _routiner;

        public CoroutineWrapper(MonoBehaviour target, Func<IEnumerator> routiner) :
            base(target)
        {
            _routiner = routiner;
        }

        public override void Start()
        {
            Stop();

            _coroutine = _target.StartCoroutine(_routiner());
        }

        public static CoroutineWrapper Create(MonoBehaviour target, Func<IEnumerator> routiner)
        {
            return new CoroutineWrapper(target, routiner);
        }

        public static CoroutineWrapper<T> Create<T>(MonoBehaviour target, Func<T, IEnumerator> routiner)
        {
            return new CoroutineWrapper<T>(target, routiner);
        }
    }

    public class CoroutineWrapper<T> : ACoroutineWrapper
    {
        private readonly Func<T, IEnumerator> _routiner;

        public CoroutineWrapper(MonoBehaviour target, Func<T, IEnumerator> routiner) :
            base(target)
        {
            _routiner = routiner;
        }

        public override void Start()
        {
            Start(default);
        }

        public void Start(T args)
        {
            Stop();

            _coroutine = _target.StartCoroutine(_routiner(args));
        }
    }
}
