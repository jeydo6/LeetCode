namespace LeetCode.Algorithms
{
	class _1480
	{
		public static int[] RunningSum(int[] numbers)
		{
			var result = new int[numbers.Length];
			result[0] = numbers[0];
			for (var i = 1; i < numbers.Length; i++)
			{
				result[i] = result[i - 1] + numbers[i];
			}
			return result;
		}
	}
}
