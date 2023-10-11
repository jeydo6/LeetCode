using System;

namespace LeetCode.Algorithms;

// HARD
internal class _664
{
	public static int StrangePrinter(string s)
	{
		var n = s.Length;
		var dp = new int[n][];
		for (var i = 0; i < n; i++)
		{
			dp[i] = new int[n];
		}

		for (var length = 1; length <= n; length++)
		{
			for (var left = 0; left <= n - length; left++)
			{
				var right = left + length - 1;
				var i = -1;
				dp[left][right] = n;
				for (var j = left; j < right; j++)
				{
					if (s[j] != s[right] && i == -1)
					{
						i = j;
					}

					if (i != -1)
					{
						dp[left][right] = Math.Min(
							dp[left][right],
							dp[i][j] + dp[j + 1][right] + 1
						);
					}
				}

				if (i == -1)
				{
					dp[left][right] = 0;
				}
			}
		}

		return dp[0][^1] + 1;
	}
}