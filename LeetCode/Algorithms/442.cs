using System;
using System.Collections.Generic;

namespace LeetCode.Algorithms
{
	// MEDIUM
	internal class _442
	{
		public static IList<int> FindDuplicates(int[] nums)
		{
			var result = new List<int>();
			for (var i = 0; i < nums.Length; i++)
			{
				var index = Math.Abs(nums[i]) - 1;
				if (nums[index] < 0)
				{
					result.Add(Math.Abs(index + 1));
				}
				nums[index] = -nums[index];
			}
			return result;
		}
	}
}
