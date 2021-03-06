using System;
using System.Collections;
using UnityEngine;

namespace Common
{
	public static class CoroutineUtility
	{
		public static IEnumerator InvokeNextFrame(Action callback)
		{
			yield return null;
			callback.Invoke();
		}

		public static IEnumerator InvokeDelayed(Action callback, float delay, bool unscaled = false)
		{
			if (unscaled)
				yield return new WaitForSecondsRealtime(delay);
			else
				yield return new WaitForSeconds(delay);
			callback.Invoke();
		}

		public static IEnumerator InvokeRepeating(Action callback, float delay)
		{
			while (true)
			{
				yield return InvokeDelayed(callback, delay);
			}
		}

		public static IEnumerator InvokeOverTime(Action<float> consumer, float duration, bool unscaled = false)
		{
			float t = 0.0f;

			while (t < duration)
			{
				consumer(t);

				t += unscaled ? Time.unscaledDeltaTime : Time.deltaTime;

				yield return null;
			}

			consumer(1.0f);
		}
	}
}
