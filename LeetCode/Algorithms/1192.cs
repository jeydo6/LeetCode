using System;
using System.Collections.Generic;

namespace LeetCode.Algorithms
{
	// HARD
	internal class _1192
	{
		public static IList<IList<int>> CriticalConnections(int n, IList<IList<int>> connections)
		{
			var graph = new Dictionary<int, IList<int>>();
			var rank = new Dictionary<int, int?>();
			var connected = new Dictionary<(int U, int V), bool>();

			for (var i = 0; i < n; i++)
			{
				graph[i] = new List<int>();
				rank[i] = null;
			}

			for (var i = 0; i < connections.Count; i++)
			{
				var u = connections[i][0];
				var v = connections[i][1];

				graph[u].Add(v);
				graph[v].Add(u);

				connected.Add((Math.Min(u, v), Math.Max(u, v)), true);
			}

			DFS(0, 0, graph, rank, connected);

			var result = new List<IList<int>>();
			foreach (var (u, v) in connected.Keys)
			{
				result.Add(new List<int> { u, v });
			}
			return result;
		}

		private static int DFS(int node, int discoveryRank, IDictionary<int, IList<int>> graph, IDictionary<int, int?> rank, IDictionary<(int U, int V), bool> connected)
		{
			if (rank[node].HasValue)
			{
				return rank[node].Value;
			}

			rank[node] = discoveryRank;
			var minRank = discoveryRank + 1;
			foreach (var neighbor in graph[node])
			{
				var neighborRank = rank[neighbor];
				if (neighborRank != null && neighborRank == discoveryRank - 1)
				{
					continue;
				}

				var recursiveRank = DFS(neighbor, discoveryRank + 1, graph, rank, connected);
				if (recursiveRank <= discoveryRank)
				{
					connected.Remove((Math.Min(node, neighbor), Math.Max(node, neighbor)));
				}
				minRank = Math.Min(minRank, recursiveRank);
			}
			return minRank;
		}
	}
}
