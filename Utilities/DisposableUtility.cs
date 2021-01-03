using System;

namespace Common
{
	public static class DisposableUtility
	{
		public static void Dispose<T>(T arg)
			where T : IDisposable
		{
			if (arg == null)
				return;

			arg.Dispose();
		}

		public static void Dispose<T>(ref T arg)
			where T : IDisposable
		{
			Dispose(arg);

			arg = default;
		}
	}
}