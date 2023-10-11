using System;

namespace LeetCode.Algorithms;

// HARD
internal class _1312
{
	public static int MinInsertions(string s1)
	{
		var s2Chars = new char[s1.Length];
		for (var i = 0; i < s1.Length; i++)
		{
			s2Chars[^(i + 1)] = s1[i];
		}
		var s2 = new string(s2Chars);

		var dp = new int[s1.Length + 1];
		var dpPrev = new int[s1.Length + 1];

		for (var i = 0; i < dp.Length; i++)
		{
			for (var j = 0; j < dp.Length; j++)
			{
				if (i == 0 || j == 0)
				{
					dp[j] = 0;
				}
				else if (s1[i - 1] == s2[j - 1])
				{
					dp[j] = 1 + dpPrev[j - 1];
				}
				else
				{
					dp[j] = Math.Max(dp[j - 1], dpPrev[j]);
				}
			}

			for (var j = 0; j < dp.Length; j++)
			{
				dpPrev[j] = dp[j];
			}
		}

		return dp.Length - dp[^1] - 1;
	}
}
