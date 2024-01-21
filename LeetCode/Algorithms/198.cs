using System;

namespace LeetCode.Algorithms;

// MEDIUM
internal sealed class _198
{
	public static int Rob(int[] nums)
	{
		if (nums.Length == 0)
		{
			return 0;
		}

		var prev1 = 0;
		var prev2 = 0;
		foreach (var num in nums)
		{
			var temp = prev1;
			prev1 = Math.Max(prev2 + num, prev1);
			prev2 = temp;
		}
		return prev1;
	}
}
