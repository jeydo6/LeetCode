using System;

namespace LeetCode.Algorithms;

// MEDIUM
internal class _918
{
	public static int MaxSubarraySumCircular(int[] nums)
	{
		var currentMax = 0;
		var currentMin = 0;
		var sum = 0;
		var maxSum = nums[0];
		var minSum = nums[0];

		for (var i = 0; i < nums.Length; i++)
		{
			var num = nums[i];

			currentMax = Math.Max(currentMax, 0) + num;
			maxSum = Math.Max(maxSum, currentMax);

			currentMin = Math.Min(currentMin, 0) + num;
			minSum = Math.Min(minSum, currentMin);

			sum += num;
		}
		return sum == minSum ? maxSum : Math.Max(maxSum, sum - minSum);
	}
}
