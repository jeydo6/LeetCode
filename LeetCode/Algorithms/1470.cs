namespace LeetCode.Algorithms
{
	class _1470
	{
		public static int[] Shuffle(int[] numbers, int n)
		{
			var result = new int[n * 2];
			for (var i = 0; i < n; i++)
			{
				result[2 * i] = numbers[i];
				result[2 * i + 1] = numbers[n + i];
			}
			return result;
		}
	}
}
