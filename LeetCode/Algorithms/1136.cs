using System;
using System.Collections.Generic;

namespace LeetCode.Algorithms
{
	// MEDIUM
	internal class _1136
	{
		public static int MinimumSemesters(int n, int[][] relations)
		{
			var graph = new List<IList<int>>(n + 1);
			for (var i = 0; i < n + 1; i++)
			{
				graph.Add(new List<int>());
			}

			for (var i = 0; i < relations.Length; i++)
			{
				graph[relations[i][0]].Add(relations[i][1]);
			}

			var maxLength = 1;
			for (var node = 1; node < graph.Count; node++)
			{
				var length = DFS(node, graph);
				if (length == -1)
				{
					return -1;
				}
				maxLength = Math.Max(length, maxLength);
			}
			return maxLength;
		}

		private static int DFS(int node, List<IList<int>> graph, int[] visited = null)
		{
			if (visited == null)
			{
				visited = new int[graph.Count];
			}

			if (visited[node] != 0)
			{
				return visited[node];
			}
			else
			{
				visited[node] = -1;
			}

			var maxLength = 1;
			for (var i = 0; i < graph[node].Count; i++)
			{
				var length = DFS(graph[node][i], graph, visited);
				if (length == -1)
				{
					return -1;
				}
				maxLength = Math.Max(length + 1, maxLength);
			}
			visited[node] = maxLength;
			return maxLength;
		}
	}
}
