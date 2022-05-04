using System.Collections.Generic;

namespace LeetCode.Algorithms
{
	// MEDIUM
	internal class _1679
	{
		public static int MaxOperations(int[] nums, int k)
		{
			var dict = new Dictionary<int, int>();
			var count = 0;
			for (var i = 0; i < nums.Length; i++)
			{
				var current = nums[i];
				var complement = k - current;

				if (dict.ContainsKey(complement) && dict[complement] > 0)
				{
					dict[complement]--;
					count++;
				}
				else
				{
					if (!dict.ContainsKey(current))
					{
						dict[current] = 0;
					}
					dict[current]++;
				}
			}
			return count;
		}
	}
}
