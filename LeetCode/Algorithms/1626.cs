using System;

namespace LeetCode.Algorithms;

// MEDIUM
internal class _1626
{
	public static int BestTeamScore(int[] scores, int[] ages)
	{
		var ageScores = new int[ages.Length][];
		for (var i = 0; i < ages.Length; i++)
		{
			ageScores[i] = new int[]
			{
				ages[i],
				scores[i]
			};
		}

		Array.Sort(ageScores, (a, b) => a[0] == b[0] ? a[1] - b[1] : a[0] - b[0]);
		
		return BestTeamScore(ageScores);
	}

	private static int BestTeamScore(int[][] ageScores)
	{
		var result = 0;

		var dp = new int[ageScores.Length];
		for (var i = 0; i < dp.Length; i++)
		{
			dp[i] = ageScores[i][1];
			result = Math.Max(result, dp[i]);
		}

		for (var i = 0; i < ageScores.Length; i++)
		{
			for (var j = i - 1; j >= 0; j--)
			{
				if (ageScores[i][1] >= ageScores[j][1])
				{
					dp[i] = Math.Max(dp[i], ageScores[i][1] + dp[j]);
				}
			}
			result = Math.Max(result, dp[i]);
		}

		return result;
	}
}
