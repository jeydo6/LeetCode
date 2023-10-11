using System;
using System.Collections.Generic;

namespace LeetCode.Algorithms;

// MEDIUM
internal class _1466
{
	public static int MinReorder(int n, int[][] connections)
	{
		var graph = new IList<int>[n];
		for (var i = 0; i < n; i++)
		{
			graph[i] = new List<int>();
		}

		for (var i = 0; i < connections.Length; i++)
		{
			graph[connections[i][0]].Add(connections[i][1]);
			graph[connections[i][1]].Add(-connections[i][0]);
		}

		return MinReorder(0, graph, new bool[n]);
	}

	private static int MinReorder(int from, IList<int>[] graph, bool[] visited)
	{
		visited[from] = true;

		var result = 0;
		foreach (var to in graph[from])
		{
			var absTo = Math.Abs(to);
			if (!visited[absTo])
			{
				result += MinReorder(absTo, graph, visited) + (to > 0 ? 1 : 0);
			}
		}
		return result;
	}
}
