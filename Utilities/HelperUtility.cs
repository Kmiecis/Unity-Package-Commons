using System;

namespace Common
{
	public static class HelperUtility
	{
		public static void AssignOrThrow<T>(ref T target, T value)
		{
			if (target != null)
			{
				throw new Exception(string.Format("Target {0} already assigned", typeof(T).Name));
			}
			target = value;
		}
	}
}