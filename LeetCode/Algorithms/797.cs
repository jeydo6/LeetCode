using System.Collections.Generic;

namespace LeetCode.Algorithms;

// MEDIUM
internal class _797
{
	public static IList<IList<int>> AllPathsSourceTarget(int[][] graph, int node = 0, IList<IList<int>> result = null, IList<int> path = null)
	{
		result ??= new List<IList<int>>();
		path ??= new List<int> { 0 };

		if (node == graph.Length - 1)
		{
			result.Add(new List<int>(path));
			return result;
		}

		for (var i = 0; i < graph[node].Length; i++)
		{
			path.Add(graph[node][i]);
			AllPathsSourceTarget(graph, graph[node][i], result, path);
			path.RemoveAt(path.Count - 1);
		}

		return result;
	}
}
