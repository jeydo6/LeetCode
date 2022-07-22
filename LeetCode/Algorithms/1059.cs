using System.Collections.Generic;

namespace LeetCode.Algorithms
{
	// MEDIUM
	internal class _1059
	{
		public static bool LeadsToDestination(int n, int[][] edges, int source, int destination)
		{
			var graph = GetGraph(n, edges);
			var states = new int[n];

			return LeadsToDestination(graph, source, destination, states);
		}

		private static bool LeadsToDestination(int[][] graph, int source, int destination, int[] states)
		{
			if (states[source] != 0)
			{
				return states[source] == 2;
			}

			if (graph[source].Length == 0)
			{
				return source == destination;
			}

			states[source] = 1;
			for (var i = 0; i < graph[source].Length; i++)
			{
				if (!LeadsToDestination(graph, graph[source][i], destination, states))
				{
					return false;
				}
			}

			states[source] = 2;
			return true;
		}

		private static int[][] GetGraph(int n, int[][] edges)
		{
			var graph = new List<int>[n];
			for (var i = 0; i < n; i++)
			{
				graph[i] = new List<int>();
			}

			for (var i = 0; i < edges.Length; i++)
			{
				graph[edges[i][0]].Add(edges[i][1]);
			}

			var result = new int[n][];
			for (var i = 0; i < n; i++)
			{
				result[i] = graph[i].ToArray();
			}

			return result;
		}
	}
}
