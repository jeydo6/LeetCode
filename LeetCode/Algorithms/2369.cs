namespace LeetCode.Algorithms;

// MEDIUM
internal class _2369
{
	public static bool ValidPartition(int[] nums)
	{
		var dp = new bool[] { true, false, false };
		for (var i = 0; i < nums.Length; i++)
		{
			var dpIndex = i + 1;
			var result = false;

			if (i > 0 && nums[i] == nums[i - 1])
			{
				result |= dp[(dpIndex - 2) % 3];
			}

			if (i > 1 && nums[i] == nums[i - 1] && nums[i] == nums[i - 2])
			{
				result |= dp[(dpIndex - 3) % 3];
			}

			if (i > 1 && nums[i] == nums[i - 1] + 1 && nums[i] == nums[i - 2] + 2)
			{
				result |= dp[(dpIndex - 3) % 3];
			}

			dp[dpIndex % 3] = result;
		}

		return dp[nums.Length % 3];
	}
}