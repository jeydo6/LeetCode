using System.Collections.Generic;

namespace LeetCode.Algorithms;

// MEDIUM
internal class _523
{
	public static bool CheckSubarraySum(int[] nums, int k)
	{
		var dict = new Dictionary<int, int>
		{
			[0] = 0
		};

		var sum = 0;
		for (var i = 0; i < nums.Length; i++)
		{
			sum += nums[i];
			if (!dict.ContainsKey(sum % k))
			{
				dict[sum % k] = i + 1;
			}
			else if (dict[sum % k] < i)
			{
				return true;
			}
		}

		return false;
	}
}
