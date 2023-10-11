using System.Collections.Generic;

namespace LeetCode.Algorithms;

// MEDIUM
internal class _1443
{
	public static int MinTime(int n, int[][] edges, IList<bool> hasApple)
	{
		var adj = new Dictionary<int, IList<int>>();
		for (var i = 0; i < edges.Length; i++)
		{
			var a = edges[i][0];
			var b = edges[i][1];
			if (!adj.ContainsKey(a))
			{
				adj[a] = new List<int>();
			}
			if (!adj.ContainsKey(b))
			{
				adj[b] = new List<int>();
			}
			adj[a].Add(b);
			adj[b].Add(a);
		}
		return MinTime(0, -1, hasApple, adj);
	}

	private static int MinTime(int n, int parent, IList<bool> hasApple, IDictionary<int, IList<int>> adj)
	{
		if (!adj.ContainsKey(n))
		{
			return 0;
		}

		var totalTime = 0;
		foreach (var child in adj[n])
		{
			if (child == parent)
			{
				continue;
			}
			var childTime = MinTime(child, n, hasApple, adj);
			if (childTime > 0 || hasApple[child])
			{
				totalTime += childTime + 2;
			}
		}
		return totalTime;
	}
}
