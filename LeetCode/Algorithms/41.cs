namespace LeetCode.Algorithms;

// HARD
internal sealed class _41
{
	public static int FirstMissingPositive(int[] nums)
	{
		var seen = new bool[nums.Length + 1];

		for (var i = 0; i < nums.Length; i++)
		{
			if (nums[i] > 0 && nums[i] <= nums.Length)
			{
				seen[nums[i]] = true;
			}
		}

		for (var i = 1; i < seen.Length; i++)
		{
			if (!seen[i])
			{
				return i;
			}
		}

		return seen.Length;
	}
}