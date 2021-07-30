using System;

namespace LeetCode.Algorithms
{
	class _1929
	{
		public static int[] GetConcatenation(int[] numbers)
		{
			var result = new int[2 * numbers.Length];

			for (var i = 0; i < numbers.Length; i++)
			{
				result[i] = numbers[i];
				result[i + numbers.Length] = numbers[i];
			}

			return result;
		}
	}
}
