namespace LeetCode.Algorithms;

// MEDIUM
internal class _983
{
	public static int MincostTickets(int[] days, int[] costs)
	{
		return MincostTickets(days, costs, 0, new int?[days.Length], new int[] { 1, 7, 30 });
	}

	private static int MincostTickets(int[] days, int[] costs, int i, int?[] dp, int[] durations)
	{
		if (i >= days.Length)
		{
			return 0;
		}

		if (dp[i] != null)
		{
			return dp[i].Value;
		}

		var result = int.MaxValue;
		var j = i;
		for (var k = 0; k < durations.Length; ++k)
		{
			while (j < days.Length && days[j] < days[i] + durations[k])
			{
				j++;
			}

			var temp = MincostTickets(days, costs, j, dp, durations) + costs[k];
			if (temp < result)
			{
				result = temp;
			}
		}

		dp[i] = result;
		return result;
	}
}
