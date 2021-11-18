using System;
using System.Collections.Generic;

namespace LeetCode.Algorithms
{
	// EASY
	internal class _448
	{
		public static IList<int> FindDisappearedNumbers(int[] nums)
		{
			for (var i = 0; i < nums.Length; i++)
			{
				var m = Math.Abs(nums[i]) - 1;
				nums[m] = nums[m] > 0 ? -nums[m] : nums[m];
			}

			var result = new List<int>();
			for (var i = 0; i < nums.Length; i++)
			{
				if (nums[i] > 0)
				{
					result.Add(i + 1);
				}
			}
			return result;
		}
	}
}
