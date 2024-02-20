namespace LeetCode.Algorithms;

// EASY
internal sealed class _268
{
	public static int MissingNumber(int[] nums)
	{
		var result = 0;
		for (var i = 0; i < nums.Length; i++)
		{
			result += i + 1 - nums[i];
		}

		return result;
	}
}