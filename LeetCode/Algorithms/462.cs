using System;

namespace LeetCode.Algorithms
{
	// MEDIUM
	internal class _462
	{
		public static int MinMoves2(int[] nums)
		{
			Array.Sort(nums);

			var result = 0;

			var lo = 0;
			var hi = nums.Length - 1;
			while (lo < hi)
			{
				result += nums[hi--] - nums[lo++];
			}

			return result;
		}
	}
}
