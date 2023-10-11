using System;

namespace LeetCode.Algorithms;

// MEDIUM
internal class _1615
{
	public static int MaximalNetworkRank(int n, int[][] roads)
	{
		var connected = new bool[n][];
		for (var i = 0; i < n; i++)
		{
			connected[i] = new bool[n];
		}

		var counts = new int[n];
		for (var i = 0; i < roads.Length; i++)
		{
			var r0 = roads[i][0];
			var r1 = roads[i][1];

			counts[r0]++;
			counts[r1]++;
			connected[r0][r1] = true;
			connected[r1][r0] = true;
		}

		var result = 0;
		for (var i = 0; i < n; i++)
		{
			for (var j = i + 1; j < n; j++)
			{
				result = Math.Max(result, counts[i] + counts[j] - (connected[i][j] ? 1 : 0));
			}
		}
		return result;
	}
}
