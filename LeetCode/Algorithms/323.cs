using System.Collections.Generic;

namespace LeetCode.Algorithms;

// MEDIUM
internal class _323
{
	public static int CountComponents(int n, int[][] edges)
	{
		var visited = new int[n];

		var list = new List<int>[n];
		for (var i = 0; i < n; i++)
		{
			list[i] = new List<int>();
		}

		for (var i = 0; i < edges.Length; i++)
		{
			list[edges[i][0]].Add(edges[i][1]);
			list[edges[i][1]].Add(edges[i][0]);
		}

		var result = 0;
		for (var i = 0; i < n; i++)
		{
			if (visited[i] == 0)
			{
				result++;
				DFS(list, visited, i);
			}
		}
		return result;
	}

	private static void DFS(List<int>[] list, int[] visited, int startNode)
	{
		visited[startNode] = 1;

		for (var i = 0; i < list[startNode].Count; i++)
		{
			var nextStartNode = list[startNode][i];
			if (visited[nextStartNode] == 0)
			{
				DFS(list, visited, nextStartNode);
			}
		}
	}
}
