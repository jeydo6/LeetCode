using System;

namespace LeetCode.Algorithms
{
	internal class _485
	{
		public static int FindMaxConsecutiveOnes(int[] nums)
		{
			var max = 0;
			var count = 0;
			for (var i = 0; i < nums.Length; i++)
			{
				if (nums[i] == 0)
				{
					count = 0;
				}
				else
				{
					count++;
					max = Math.Max(max, count);
				}
			}
			return max;
		}
	}
}
