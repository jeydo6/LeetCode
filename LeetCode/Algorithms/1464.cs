using System;

namespace LeetCode.Algorithms
{
	class _1464
	{
		public static int MaxProduct(int[] numbers)
		{
			Array.Sort(numbers);
			return (numbers[^1] - 1) * (numbers[^2] - 1);
		}
	}
}
