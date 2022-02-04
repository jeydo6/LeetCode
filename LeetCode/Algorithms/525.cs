using System;
using System.Collections.Generic;

namespace LeetCode.Algorithms
{
	// MEDIUM
	internal class _525
	{
		public static int FindMaxLength(int[] nums)
		{
			for (var i = 0; i < nums.Length; i++)
			{
				if (nums[i] == 0) nums[i] = -1;
			}

			var dict = new Dictionary<int, int>
			{
				[0] = -1
			};

			var sum = 0;
			var max = 0;
			for (var i = 0; i < nums.Length; i++)
			{
				sum += nums[i];
				if (dict.ContainsKey(sum))
				{
					max = Math.Max(max, i - dict[sum]);
				}
				else
				{
					dict[sum] = i;
				}
			}
			return max;
		}
	}
}
