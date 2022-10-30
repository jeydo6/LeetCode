using System;

namespace LeetCode.Algorithms;

// MEDIUM
internal class _487
{
	public static int FindMaxConsecutiveOnes(int[] nums)
	{
		var result = 0;
		var left = 0;
		var right = 0;
		var zeroes = 0;

		while (right < nums.Length)
		{
			if (nums[right] == 0)
			{
				zeroes++;
			}

			while (zeroes == 2)
			{
				if (nums[left] == 0)
				{
					zeroes--;
				}
				left++;
			}

			result = Math.Max(result, right - left + 1);

			right++;
		}
		return result;
	}
}
