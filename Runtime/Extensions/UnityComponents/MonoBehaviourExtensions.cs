using System.Collections;
using UnityEngine;

namespace Common.Extensions
{
    public static class MonoBehaviourExtensions
    {
        public static Coroutine StartCoroutineSafely(this MonoBehaviour self, string methodName)
        {
            if (self.isActiveAndEnabled)
                return self.StartCoroutine(methodName);
            return null;
        }

        public static Coroutine StartCoroutineSafely(this MonoBehaviour self, string methodName, object value)
        {
            if (self.isActiveAndEnabled)
                return self.StartCoroutine(methodName, value);
            return null;
        }

        public static Coroutine StartCoroutineSafely(this MonoBehaviour self, IEnumerator routine)
        {
            if (self.isActiveAndEnabled)
                return self.StartCoroutine(routine);
            return null;
        }
    }
}