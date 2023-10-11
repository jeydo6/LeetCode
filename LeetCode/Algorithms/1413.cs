using System;

namespace LeetCode.Algorithms
{
	// EASY
	internal class _1413
	{
		public static int MinStartValue(int[] nums)
		{
			var sum = 0;
			var min = 0;
			foreach (var num in nums)
			{
				sum += num;
				min = Math.Min(min, sum);
			}
			return 1 - min;
		}
	}
}
