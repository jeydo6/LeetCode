namespace LeetCode.Algorithms
{
	// MEDIUM
	internal class _416
	{
		public static bool CanPartition(int[] nums)
		{
			var sum = 0;

			foreach (var num in nums)
			{
				sum += num;
			}

			if ((sum & 1) == 1)
			{
				return false;
			}
			sum /= 2;

			var n = nums.Length;
			var dp = new bool[sum + 1];
			dp[0] = true;

			foreach (var num in nums)
			{
				for (var i = sum; i > 0; i--)
				{
					if (i >= num)
					{
						dp[i] = dp[i] || dp[i - num];
					}
				}
			}
			return dp[sum];
		}
	}
}
