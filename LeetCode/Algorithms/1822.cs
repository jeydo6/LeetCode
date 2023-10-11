namespace LeetCode.Algorithms;

// EASY
internal class _1822
{
	public static int ArraySign(int[] nums)
	{
		var result = 1;
		for (var i = 0; i < nums.Length; i++)
		{
			if (nums[i] == 0)
			{
				return 0;
			}
			else if (nums[i] < 0)
			{
				result *= -1;
			}
		}

		return result;
	}
}
