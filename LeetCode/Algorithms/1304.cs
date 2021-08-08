namespace LeetCode.Algorithms
{
	// EASY
	class _1304
	{
		public static int[] SumZero(int n)
		{
			var result = new int[n];
			for (int i = 0; i < n; i++)
			{
				result[i] = i * 2 - n + 1;
			}
			return result;
		}
	}
}
