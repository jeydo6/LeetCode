using System.Collections.Generic;

namespace LeetCode.Algorithms;

// EASY
internal class _1971
{
	public static bool ValidPath(int n, int[][] edges, int source, int destination)
	{
		var graph = new Dictionary<int, IList<int>>();
		foreach (var edge in edges)
		{
			if (!graph.ContainsKey(edge[0]))
			{
				graph[edge[0]] = new List<int>();
			}
			graph[edge[0]].Add(edge[1]);
			if (!graph.ContainsKey(edge[1]))
			{
				graph[edge[1]] = new List<int>();
			}
			graph[edge[1]].Add(edge[0]);
		}

		var seen = new bool[n];
		seen[source] = true;

		var stack = new Stack<int>();
		stack.Push(source);

		while (stack.Count > 0)
		{
			var currentNode = stack.Pop();
			if (currentNode == destination)
			{
				return true;
			}

			foreach (var nextNode in graph[currentNode])
			{
				if (!seen[nextNode])
				{
					seen[nextNode] = true;
					stack.Push(nextNode);
				}
			}
		}

		return false;
	}
}
