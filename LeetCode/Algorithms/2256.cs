using System;

namespace LeetCode.Algorithms;

// MEDIUM
internal class _2256
{
	public static int MinimumAverageDifference(int[] nums)
	{
		var totalSum = 0L;
		for (var index = 0; index < nums.Length; index++)
		{
			totalSum += nums[index];
		}

		var result = -1;
		var minimumDifference = int.MaxValue;
		var currentPrefixSum = 0L;
		for (var index = 0; index < nums.Length; index++)
		{
			currentPrefixSum += nums[index];

			var leftPartAverage = currentPrefixSum;
			leftPartAverage /= index + 1;

			var rightPartAverage = totalSum - currentPrefixSum;
			if (index != nums.Length - 1)
			{
				rightPartAverage /= nums.Length - index - 1;
			}

			var currentDifference = (int)Math.Abs(leftPartAverage - rightPartAverage);
			if (currentDifference < minimumDifference)
			{
				minimumDifference = currentDifference;
				result = index;
			}
		}

		return result;
	}
}
