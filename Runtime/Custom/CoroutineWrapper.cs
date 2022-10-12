using System;
using System.Collections;
using UnityEngine;

namespace Common
{
    public class CoroutineWrapper : IDisposable
    {
        protected Coroutine _coroutine;

        protected MonoBehaviour _target;
        protected Func<IEnumerator> _enumerator;

        public CoroutineWrapper WithTarget(MonoBehaviour target)
        {
            _target = target;
            return this;
        }

        public CoroutineWrapper WithEnumerator(Func<IEnumerator> enumerator)
        {
            _enumerator = enumerator;
            return this;
        }

        public CoroutineWrapper With(MonoBehaviour target, Func<IEnumerator> enumerator)
        {
            return WithTarget(target)
                .WithEnumerator(enumerator);
        }

        public CoroutineWrapper Start()
        {
            Stop();

            if (_target != null && _enumerator != null)
            {
                _coroutine = _target.StartCoroutine(_enumerator());
            }

            return this;
        }

        public void Stop()
        {
            if (_coroutine != null)
            {
                if (_target != null)
                {
                    _target.StopCoroutine(_coroutine);
                }
                
                _coroutine = null;
            }
        }

        public void Dispose()
        {
            Stop();
        }
    }

    public class CoroutineWrapper<T> : IDisposable
    {
        protected Coroutine _coroutine;

        protected MonoBehaviour _target;
        protected Func<T, IEnumerator> _enumerator;

        public CoroutineWrapper<T> WithTarget(MonoBehaviour target)
        {
            _target = target;
            return this;
        }

        public CoroutineWrapper<T> WithEnumerator(Func<T, IEnumerator> enumerator)
        {
            _enumerator = enumerator;
            return this;
        }

        public CoroutineWrapper<T> With(MonoBehaviour target, Func<T, IEnumerator> enumerator)
        {
            return WithTarget(target)
                .WithEnumerator(enumerator);
        }

        public CoroutineWrapper<T> Start(T value)
        {
            Stop();

            if (_target != null && _enumerator != null)
            {
                _coroutine = _target.StartCoroutine(_enumerator(value));
            }

            return this;
        }

        public void Stop()
        {
            if (_coroutine != null)
            {
                if (_target != null)
                {
                    _target.StopCoroutine(_coroutine);
                }

                _coroutine = null;
            }
        }

        public void Dispose()
        {
            Stop();
        }
    }
}
