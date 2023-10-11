using System;
using System.Collections.Generic;

namespace LeetCode.Algorithms
{
	// MEDIUM
	internal class _128
	{
		public static int LongestConsecutive(int[] nums)
		{
			var hashSet = new HashSet<int>();

			for (var i = 0; i < nums.Length; i++)
			{
				hashSet.Add(nums[i]);
			}

			var result = 0;

			for (var i = 0; i < nums.Length; i++)
			{
				var currentStreak = 1;
				var currentNum = nums[i];

				if (hashSet.Contains(currentNum - 1))
				{
					continue;
				}

				while (hashSet.Contains(currentNum + 1))
				{
					currentNum += 1;
					currentStreak += 1;
				}

				result = Math.Max(result, currentStreak);
			}

			return result;
		}
	}
}
