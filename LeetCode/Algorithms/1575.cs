using System;

namespace LeetCode.Algorithms;

// HARD
public class _1575
{
	private const int Modulo = 1_000_000_007;

	public static int CountRoutes(int[] locations, int start, int finish, int fuel)
	{
		var n = locations.Length;
		var dp = new int[n][];
		for (var i = 0; i < n; i++)
		{
			dp[i] = new int[fuel + 1];
		}

		for (var j = 0; j < fuel + 1; j++)
		{
			dp[finish][j] = 1;
		}

		for (var j = 0; j < fuel + 1; j++)
		{
			for (var i = 0; i < n; i++)
			{
				for (var k = 0; k < n; k++)
				{
					if (k == i)
					{
						continue;
					}

					if (Math.Abs(locations[i] - locations[k]) <= j)
					{
						dp[i][j] = (dp[i][j] + dp[k][j - Math.Abs(locations[i] - locations[k])]) % Modulo;
					}
				}
			}
		}

		return dp[start][fuel];
	}
}