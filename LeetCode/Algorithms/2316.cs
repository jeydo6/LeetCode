using System.Collections.Generic;

namespace LeetCode.Algorithms;

// MEDIUM
internal class _2316
{
	public static long CountPairs(int n, int[][] edges)
	{
		var graph = new IList<int>[n];
		for (var i = 0; i < n; i++)
		{
			graph[i] = new List<int>();
		}

		for (var i = 0; i < edges.Length; i++)
		{
			graph[edges[i][0]].Add(edges[i][1]);
			graph[edges[i][1]].Add(edges[i][0]);
		}

		var result = 0L;
		var visited = new bool[n];
		var visitedCount = 0L;
		for (var from = 0; from < n; from++)
		{
			if (visited[from])
			{
				var count = CountPairs(from, graph, new bool[n]);
				result += visitedCount * count;
				visitedCount += count;
			}
		}
		return result;
	}

	private static long CountPairs(int from, IList<int>[] graph, bool[] visited)
	{
		visited[from] = true;
		var result = 1L;
		foreach (var to in graph[from])
		{
			if (!visited[to])
			{
				result += CountPairs(to, graph, visited);
			}
		}
		return result;
	}
}
