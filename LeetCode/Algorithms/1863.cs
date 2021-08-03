using System.Collections.Generic;

namespace LeetCode.Algorithms
{
	class _1863
	{
		public static int SubsetXORSum(int[] numbers)
		{
			var result = 0;
			foreach (var number in numbers)
			{
				result |= number;
			}
			return result * (1 << numbers.Length - 1);
		}
	}
}
