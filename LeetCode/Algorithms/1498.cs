using System;

namespace LeetCode.Algorithms;

// MEDIUM
internal class _1498
{
	private const int Modulo = 1_000_000_007;

	public static int NumSubseq(int[] nums, int target)
	{
		Array.Sort(nums);

		var powers = new int[nums.Length];
		powers[0] = 1;
		for (var i = 1; i < powers.Length; ++i)
		{
			powers[i] = powers[i - 1] * 2 % Modulo;
		}

		var result = 0;
		var left = 0;
		var right = nums.Length - 1;
		while (left <= right)
		{
			if (nums[left] + nums[right] <= target)
			{
				result += powers[right - left];
				result %= Modulo;
				left++;
			}
			else
			{
				right--;
			}
		}

		return result;
	}
}
