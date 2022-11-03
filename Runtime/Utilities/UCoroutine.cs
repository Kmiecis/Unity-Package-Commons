using System;
using System.Collections;
using UnityEngine;

namespace Common
{
    public static class UCoroutine
    {
        public static IEnumerator InvokeNextFrame(Action callback)
        {
            yield return null;
            callback.Invoke();
        }

        public static IEnumerator InvokeEachFrame(Action callback)
        {
            while (true)
            {
                yield return null;
                callback.Invoke();
            }
        }

        public static IEnumerator InvokeDelayed(Action callback, float delay, bool unscaled = false)
        {
            if (unscaled)
                yield return new WaitForSecondsRealtime(delay);
            else
                yield return new WaitForSeconds(delay);
            callback.Invoke();
        }

        public static IEnumerator InvokeRepeating(Action callback, float delay, bool unscaled = false)
        {
            while (true)
            {
                yield return InvokeDelayed(callback, delay, unscaled);
            }
        }

        public static IEnumerator InvokeChained(params IEnumerator[] coroutines)
        {
            foreach (var coroutine in coroutines)
            {
                while (coroutine.MoveNext())
                {
                    yield return coroutine.Current;
                }
            }
        }

        public static IEnumerator InvokeOverTime(Action<float> consumer, float duration, bool unscaled = false)
        {
            float t = 0.0f;

            while (t < duration)
            {
                consumer(t);

                t += UTime.GetDeltaTime(unscaled);

                yield return null;
            }

            consumer(duration);
        }

        public static IEnumerator InvokeOverTimeNormalized(Action<float> consumer, float duration, bool unscaled = false)
        {
            float t = 0.0f;
            float n = 1.0f / duration;

            while (t < 1.0f)
            {
                consumer(t);

                t += n * UTime.GetDeltaTime(unscaled);

                yield return null;
            }

            consumer(1.0f);
        }
    }
}
