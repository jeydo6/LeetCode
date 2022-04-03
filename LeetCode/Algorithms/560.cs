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
			var dict = new Dictionary<int, int>
			{
				[0] = 1
			};
			for (var i = 0; i < nums.Length; i++)
			{
				sum += nums[i];
				if (dict.ContainsKey(sum - k))
				{
					result += dict[sum - k];
				}
				if (!dict.ContainsKey(sum))
				{
					dict[sum] = 0;
				}
				dict[sum]++;
			}

			return result;
		}
	}
}
