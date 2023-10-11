namespace Leetcode.Algorithms;

// EASY
internal class _136
{
	public static int SingleNumber(int[] nums)
	{
		var result = 0;
		for (var i = 0; i < nums.Length; i++)
		{
			result ^= nums[i];
		}
		return result;
	}
}
