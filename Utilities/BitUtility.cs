using System.Runtime.CompilerServices;

namespace Common
{
    public static class BitUtility
    {
        [MethodImpl(MethodImplOptions.AggressiveInlining)]
        public static bool IsBit(int value, int bit)
        {
            return (value & bit) == bit;
        }

        [MethodImpl(MethodImplOptions.AggressiveInlining)]
        public static bool IsSet(int value, int bit)
        {
            return (value & bit) != 0;
        }

        [MethodImpl(MethodImplOptions.AggressiveInlining)]
        public static bool IsEqual(int value, int lbit, int rbit)
        {
            return (value & lbit) == (value & rbit);
        }

        [MethodImpl(MethodImplOptions.AggressiveInlining)]
        public static void SetBit(ref int value, int bit)
        {
            value |= bit;
        }

        [MethodImpl(MethodImplOptions.AggressiveInlining)]
        public static void ClearBit(ref int value, int bit)
        {
            value &= ~bit;
        }
    }
}