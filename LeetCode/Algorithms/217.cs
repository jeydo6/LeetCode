using System.Collections.Generic;

namespace LeetCode.Algorithms
{
	// EASY
	internal class _217
	{
		public static bool ContainsDuplicate(int[] nums)
		{
			var hashSet = new HashSet<int>();
			for (var i = 0; i < nums.Length; i++)
			{
				if (hashSet.Contains(nums[i]))
				{
					return true;
				}
				hashSet.Add(nums[i]);
			}
			return false;
		}
	}
}
