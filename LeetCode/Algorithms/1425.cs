using System.Collections.Generic;

namespace LeetCode.Algorithms;

// HARD
internal class _1425
{
	public static int ConstrainedSubsetSum(int[] nums, int k)
	{
		var queue = new LinkedList<int>();
		var dp = new int[nums.Length];
		for (var i = 0; i < dp.Length; i++)
		{
			if (queue.Count > 0 && i - queue.First.Value > k)
			{
				queue.RemoveFirst();
			}

			dp[i] = (queue.Count > 0 ? dp[queue.First.Value] : 0) + nums[i];
			while (queue.Count > 0 && dp[queue.Last.Value] < dp[i])
			{
				queue.RemoveLast();
			}

			if (dp[i] > 0)
			{
				queue.AddLast(i);
			}
		}

		var result = int.MinValue;
		for (var i = 0; i < dp.Length; i++)
		{
			if (dp[i] > result)
			{
				result = dp[i];
			}
		}

		return result;
	}
}
