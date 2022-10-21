using System.Collections.Generic;

namespace LeetCode.Algorithms;

// EASY
internal class _219
{
	public static bool ContainsNearbyDuplicate(int[] nums, int k)
	{
		var hashSet = new HashSet<int>();
		for (var i = 0; i < nums.Length; i++)
		{
			if (hashSet.Contains(nums[i]))
			{
				return true;
			}

			hashSet.Add(nums[i]);

			if (hashSet.Count > k)
			{
				hashSet.Remove(nums[i - k]);
			}
		}

		return false;
	}
}
