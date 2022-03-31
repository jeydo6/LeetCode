using System;

namespace LeetCode.Algorithms
{

	// HARD
	internal class _410
	{
		public static int SplitArray(int[] nums, int m)
		{
			var sum = 0;
			var max = int.MinValue;
			for (var i = 0; i < nums.Length; i++)
			{
				sum += nums[i];
				max = Math.Max(max, nums[i]);
			}

			var left = max;
			var right = sum;
			var minimumLargestSum = 0;
			while (left <= right)
			{
				var maxSumAllowed = left + (right - left) / 2;

				if (GetSubarraysCount(nums, maxSumAllowed) <= m)
				{
					right = maxSumAllowed - 1;
					minimumLargestSum = maxSumAllowed;
				}
				else
				{
					left = maxSumAllowed + 1;
				}
			}

			return minimumLargestSum;
		}

		private static int GetSubarraysCount(int[] nums, int maxSumAllowed)
		{
			var sum = 0;
			var splits = 0;

			for (var i = 0; i < nums.Length; i++)
			{
				if (sum + nums[i] <= maxSumAllowed)
				{
					sum += nums[i];
				}
				else
				{
					sum = nums[i];
					splits++;
				}
			}
			return splits + 1;
		}
	}
}
