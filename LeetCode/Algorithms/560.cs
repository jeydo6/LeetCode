using System.Collections.Generic;

namespace LeetCode.Algorithms
{
	// MEDIUM
	internal class _560
	{
		public static int SubarraySum(int[] nums, int k)
		{
			var result = 0;

			var sum = 0;
			var preSum = new Dictionary<int, int>
			{
				[0] = 1
			};
			for (var i = 0; i < nums.Length; i++)
			{
				sum += nums[i];
				if (preSum.ContainsKey(sum - k))
				{
					result += preSum[sum - k];
				}
				if (!preSum.ContainsKey(sum))
				{
					preSum[sum] = 0;
				}
				preSum[sum]++;
			}

			return result;
		}
	}
}
