using System.Collections.Generic;

namespace LeetCode.Algorithms
{
	// MEDIUM
	internal class _532
	{
		public static int FindPairs(int[] nums, int k)
		{
			if (nums == null || nums.Length == 0 || k < 0)
			{
				return 0;
			}

			var dict = new Dictionary<int, int>();
			var count = 0;
			for (var i = 0; i < nums.Length; i++)
			{
				if (!dict.ContainsKey(nums[i]))
				{
					dict[nums[i]] = 0;
				}

				dict[nums[i]]++;
			}

			foreach (var pair in dict)
			{
				if (k == 0)
				{
					if (pair.Value >= 2)
					{
						count++;
					}
				}
				else
				{
					if (dict.ContainsKey(pair.Key + k))
					{
						count++;
					}
				}
			}

			return count;
		}
	}
}
