using System;

namespace LeetCode.Algorithms
{
	class _1827
	{
		public static int MinOperations(int[] numbers)
		{
			var result = 0;
			for (var i = 1; i < numbers.Length; i++)
			{
				var temp = numbers[i];
				numbers[i] = Math.Max(numbers[i - 1] + 1, numbers[i]);
				result += numbers[i] - temp;
			}
			return result;
		}
	}
}
