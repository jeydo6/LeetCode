using System;

namespace Leetcode.Algorithms
{
	internal class _561
	{
		public static int ArrayPairSum(int[] numbers)
		{
			var result = 0;

			Array.Sort(numbers);

			for (var i = 0; i < numbers.Length; i += 2)
			{
				result += numbers[i];
			}

			return result;
		}
	}
}
