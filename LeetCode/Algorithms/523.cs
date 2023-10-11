using System.Collections.Generic;

namespace LeetCode.Algorithms;

// MEDIUM
internal class _523
{
	public static bool CheckSubarraySum(int[] nums, int k)
	{
		var sum = new int[nums.Length + 1];
		for (var i = 1; i <= nums.Length; i++)
		{
			sum[i] = sum[i - 1] + nums[i - 1];
		}

		var hashSet = new HashSet<int>();
		for (var i = 2; i <= nums.Length; i++)
		{
			hashSet.Add(sum[i - 2] % k);
			
			if (hashSet.Contains(sum[i] % k))
			{
				return true;
			}
		}

		return false;
	}
}
