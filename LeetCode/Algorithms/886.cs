using System.Collections.Generic;

namespace LeetCode.Algorithms;

// MEDIUM
internal class _886
{
	public static bool PossibleBipartition(int n, int[][] dislikes)
	{
		var adjDislikes = new Dictionary<int, IList<int>>();
		foreach (var edge in dislikes)
		{
			if (!adjDislikes.ContainsKey(edge[0]))
			{
				adjDislikes[edge[0]] = new List<int>();
			}
			adjDislikes[edge[0]].Add(edge[1]);

			if (!adjDislikes.ContainsKey(edge[1]))
			{
				adjDislikes[edge[1]] = new List<int>();
			}
			adjDislikes[edge[1]].Add(edge[0]);
		}

		var colors = new int[n + 1];
		for (var i = 0; i < n + 1; i++)
		{
			colors[i] = -1;
		}

		for (var i = 0; i < n + 1; i++)
		{
			if (colors[i] == -1)
			{
				if (!DFS(i, 0, adjDislikes, colors))
				{
					return false;
				}
			}
		}
		return true;
	}

	private static bool DFS(int node, int color, IDictionary<int, IList<int>> dislikes, int[] colors)
	{
		colors[node] = color;
		if (!dislikes.ContainsKey(node))
		{
			return true;
		}

		foreach (var neighbor in dislikes[node])
		{
			if (colors[neighbor] == colors[node])
			{
				return false;
			}

			if (colors[neighbor] == -1)
			{
				if (!DFS(neighbor, 1 - color, dislikes, colors))
				{
					return false;
				}
			}
		}
		return true;
	}
}
