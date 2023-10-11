using System;

namespace LeetCode.Algorithms;

// MEDIUM
internal class _55
{
	public static bool CanJump(int[] nums)
	{
		var index = 0;
		for (var i = 0; i <= index; i++)
		{
			index = Math.Max(index, i + nums[i]);

			if (index >= nums.Length - 1)
			{
				return true;
			}
		}
		return false;
	}
}
