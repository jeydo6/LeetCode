namespace LeetCode.Algorithms
{
	class _191
	{
		public static int HammingWeight(uint n)
		{
			var count = 0U;
			while (n != 0)
			{
				count += n & 1;
				n >>= 1;
			}
			return (int)count;
		}
	}
}
