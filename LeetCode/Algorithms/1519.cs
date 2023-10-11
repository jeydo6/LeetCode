using System.Collections.Generic;

namespace LeetCode.Algorithms;

// MEDIUM
internal class _1519
{
	public static int[] CountSubTrees(int n, int[][] edges, string labels)
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

		var counts = new int[n][];
		for (var i = 0; i < counts.Length; i++)
		{
			counts[i] = new int[26];
		}

		var queue = new Queue<int>();
		for (var i = 0; i < n; i++)
		{
			counts[i][labels[i] - 'a'] = 1;
			if (i != 0 && adj[i].Count == 1)
			{
				queue.Enqueue(i);
			}
		}

		while (queue.Count > 0)
		{
			var node = queue.Dequeue();
			var parent = adj[node][0];

			adj[parent].Remove(node);
			for (var i = 0; i < 26; i++)
			{
				counts[parent][i] += counts[node][i];
			}

			if (parent != 0 && adj[parent].Count == 1)
			{
				queue.Enqueue(parent);
			}
		}

		var result = new int[n];
		for (int i = 0; i < n; i++)
		{
			result[i] = counts[i][labels[i] - 'a'];
		}
		return result;
	}
}
