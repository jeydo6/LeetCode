using System;

namespace LeetCode.Algorithms;

// HARD
internal class _1335
{
	public static int MinDifficulty(int[] jobDifficulty, int d)
	{
		var minDifficulty = new int[d + 1][];
		for (var i = 0; i < minDifficulty.Length; i++)
		{
			minDifficulty[i] = new int[jobDifficulty.Length + 1];
		}

		for (var daysRemaining = 0; daysRemaining <= d; daysRemaining++)
		{
			for (var i = 0; i < jobDifficulty.Length; i++)
			{
				minDifficulty[daysRemaining][i] = int.MaxValue;
			}
		}
		for (var daysRemaining = 1; daysRemaining <= d; daysRemaining++)
		{
			for (var i = 0; i < jobDifficulty.Length - daysRemaining + 1; i++)
			{
				var dailyMaxJobDifficulty = 0;
				for (int j = i + 1; j < jobDifficulty.Length - daysRemaining + 2; j++)
				{
					dailyMaxJobDifficulty = Math.Max(dailyMaxJobDifficulty, jobDifficulty[j - 1]);
					if (minDifficulty[daysRemaining - 1][j] != int.MaxValue)
					{
						minDifficulty[daysRemaining][i] = Math.Min(
							minDifficulty[daysRemaining][i],
							dailyMaxJobDifficulty + minDifficulty[daysRemaining - 1][j]
						);
					}
				}
			}
		}
		return minDifficulty[d][0] < int.MaxValue ? minDifficulty[d][0] : -1;
	}
}
