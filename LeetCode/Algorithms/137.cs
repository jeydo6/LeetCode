namespace LeetCode.Algorithms;

// MEDIUM
internal class _137
{
	public static int SingleNumber(int[] nums)
	{
		var ones = 0;
		var twos = 0;
		for (var i = 0; i < nums.Length; i++)
		{
			ones = (ones ^ nums[i]) & ~twos;
			twos = (twos ^ nums[i]) & ~ones;
		}

		return ones;
	}
}