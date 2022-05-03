using System;

namespace LeetCode.Algorithms
{
	// MEDIUM
	internal class _581
	{
		public static int FindUnsortedSubarray(int[] nums)
		{
			var flag = false;
			var min = int.MaxValue;
			for (var i = 1; i < nums.Length; i++)
			{
				if (nums[i] < nums[i - 1])
				{
					flag = true;
				}

				if (flag)
				{
					min = Math.Min(min, nums[i]);
				}
			}

			flag = false;
			var max = int.MinValue;
			for (var i = nums.Length - 2; i >= 0; i--)
			{
				if (nums[i] > nums[i + 1])
				{
					flag = true;
				}

				if (flag)
				{
					max = Math.Max(max, nums[i]);
				}
			}

			var l = 0;
			while (l < nums.Length)
			{
				if (min < nums[l])
				{
					break;
				}
				l++;
			}

			var r = nums.Length - 1;
			while (r >= 0)
			{
				if (max > nums[r])
				{
					break;
				}
				r--;
			}

			return r - l < 0 ? 0 : r - l + 1;
		}
	}
}
