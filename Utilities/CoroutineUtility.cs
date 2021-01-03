using System;
using System.Collections;
using UnityEngine;

namespace Common
{
    public static class CoroutineUtility
    {
        public static IEnumerator CreateInvokeNextFrame(Action callback)
        {
            yield return null;
            callback.Invoke();
        }

        public static IEnumerator CreateInvokeDelayed(Action callback, float delay)
        {
            yield return new WaitForSecondsRealtime(delay);
            callback.Invoke();
        }

        public static IEnumerator CreateInvokeRepeating(Action callback, float delay)
        {
            while (true)
            {
                yield return CreateInvokeDelayed(callback, delay);
            }
        }
    }
}
