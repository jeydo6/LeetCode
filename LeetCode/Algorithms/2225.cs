using System.Collections.Generic;

namespace LeetCode.Algorithms;

// MEDIUM
internal sealed class _2225
{
	public static IList<IList<int>> FindWinners(int[][] matches)
	{
		var losses = new int[100001];
		for (var i = 0; i < losses.Length; i++)
		{
			losses[i] = -1;
		}

		for (var i = 0; i < matches.Length; i++)
		{
			var winner = matches[i][0];
			var loser = matches[i][1];

			if (losses[winner] == -1)
			{
				losses[winner] = 0;
			}

			if (losses[loser] == -1)
			{
				losses[loser] = 1;
			}
			else
			{
				losses[loser]++;
			}
		}

		var result = new List<IList<int>>
		{
			new List<int>(),
			new List<int>()
		};

		for (var i = 1; i < losses.Length; i++)
		{
			if (losses[i] == 0)
			{
				result[0].Add(i);
			}
			else if (losses[i] == 1)
			{
				result[1].Add(i);
			}
		}

		return result;
	}
}
