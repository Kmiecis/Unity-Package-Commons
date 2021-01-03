using System.Runtime.CompilerServices;

namespace Common
{
	public static class BitUtility
	{
		[MethodImpl(MethodImplOptions.AggressiveInlining)]
		public static bool IsFlag(int value, int flag)
		{
			return (value & flag) == flag;
		}

		[MethodImpl(MethodImplOptions.AggressiveInlining)]
		public static bool HasFlag(int value, int flag)
		{
			return (value & flag) != 0;
		}
	}
}