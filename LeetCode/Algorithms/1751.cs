using System;

namespace LeetCode.Algorithms;

// HARD
internal class _1751
{
	public static int MaxValue(int[][] events, int k)
	{
		var n = events.Length;
		var dp = new int[k + 1][];
		for (var i = 0; i < dp.Length; i++)
		{
			dp[i] = new int[n + 1];
		}

		Array.Sort(events, (a, b) => a[0] - b[0]);

		for (var currentIndex = n - 1; currentIndex >= 0; currentIndex--)
		{
			var nextIndex = BisectRight(events, events[currentIndex][1]);
			for (var count = 1; count <= k; count++)
			{
				dp[count][currentIndex] = Math.Max(
					dp[count][currentIndex + 1],
					events[currentIndex][2] + dp[count - 1][nextIndex]);
			}
		}

		return dp[k][0];
	}

	private static int BisectRight(int[][] events, int target)
	{
		var lo = 0;
		var hi = events.Length;
		while (lo < hi)
		{
			var mid = lo + (hi - lo) / 2;
			if (events[mid][0] <= target)
			{
				lo = mid + 1;
			}
			else
			{
				hi = mid;
			}
		}

		return lo;
	}
}