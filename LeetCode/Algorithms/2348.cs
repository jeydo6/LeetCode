namespace LeetCode.Algorithms;

// MEDIUM
internal class _2348
{
	public static long ZeroFilledSubarray(int[] nums)
	{
		var result = 0L;
		var j = 0;
		for (int i = 0; i < nums.Length; i++)
		{
			if (nums[i] != 0)
			{
				j = i + 1;
			}
			result += i - j + 1;
		}
		return result;
	}
}
