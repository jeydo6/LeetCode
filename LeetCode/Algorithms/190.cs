namespace LeetCode.Algorithms
{
	class _190
	{
		public static uint ReverseBits(uint n)
		{
			uint result = 0;
			for (int i = 0; i < 32; i++)
			{
				result <<= 1;
				result |= n & 1;
				n >>= 1;
			}
			return result;
		}
	}
}
