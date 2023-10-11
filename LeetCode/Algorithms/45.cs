using System;

namespace LeetCode.Algorithms;

// MEDIUM
internal class _45
{
	public static int Jump(int[] nums)
	{
		var result = 0;

		var currentEnd = 0;
		var currentFar = 0;
		for (var i = 0; i < nums.Length - 1; ++i)
		{
			currentFar = Math.Max(currentFar, i + nums[i]);

			if (i == currentEnd)
			{
				result++;
				currentEnd = currentFar;
			}
		}

		return result;
	}
}
