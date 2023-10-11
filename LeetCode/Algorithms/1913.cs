using System;

namespace LeetCode.Algorithms
{
	class _1913
	{
		public static int MaxProductDifference(int[] numbers)
		{
			Array.Sort(numbers);
			return numbers[^1] * numbers[^2] - numbers[1] * numbers[0];
		}
	}
}
