namespace LeetCode.Algorithms
{
	class _1486
	{
		public static int XorOperation(int n, int start)
		{
			var result = start;
			for (var i = 1; i < n; i++)
			{
				result ^= start + 2 * i;
			}
			return result;
		}
	}
}
