using UnityEngine;

namespace Common
{
	public static class ObjectUtility
	{
		public static void DestroySafely<T>(T obj)
			where T : Object
		{
			if (obj == null)
				return;

			if (Application.isPlaying)
				Object.Destroy(obj);
			else
				Object.DestroyImmediate(obj);
		}

		public static void DestroySafely<T>(ref T obj)
			where T : Object
		{
			DestroySafely(obj);

			obj = null;
		}
	}
}