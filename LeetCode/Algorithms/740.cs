using System;
using System.Collections.Generic;

namespace LeetCode.Algorithms
{
	// MEDIUM
	internal class _740
	{
		public static int DeleteAndEarn(int[] nums)
		{
			var maxNumber = 0;
			var points = new Dictionary<int, int>();
			for (var i = 0; i < nums.Length; i++)
			{
				if (!points.ContainsKey(nums[i]))
				{
					points[nums[i]] = 0;
				}
				points[nums[i]] += nums[i];
				maxNumber = Math.Max(maxNumber, nums[i]);
			}

			var twoBack = 0;
			var oneBack = points.ContainsKey(1) ? points[1] : 0;
			for (var num = 2; num <= maxNumber; num++)
			{
				var temp = oneBack;
				oneBack = Math.Max(oneBack, twoBack + (points.ContainsKey(num) ? points[num] : 0));
				twoBack = temp;
			}
			return oneBack;
		}
	}
}
