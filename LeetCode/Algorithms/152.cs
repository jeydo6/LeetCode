using System;

namespace LeetCode.Algorithms
{
	// MEDIUM
	internal class _152
	{
		public static int MaxProduct(int[] nums)
		{
			var result = nums[0];
			var max = result;
			var min = result;
			for (var i = 1; i < nums.Length; i++)
			{
				if (nums[i] < 0)
				{
					(min, max) = (max, min);
				}

				max = Math.Max(nums[i], max * nums[i]);
				min = Math.Min(nums[i], min * nums[i]);

				result = Math.Max(result, max);
			}
			return result;
		}
	}
}
