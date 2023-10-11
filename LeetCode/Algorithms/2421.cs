using System.Collections.Generic;

namespace LeetCode.Algorithms;

// HARD
internal class _2421
{
	private class UnionFind
	{
		private readonly int[] _parent;
		private readonly int[] _rank;

		public UnionFind(int size)
		{
			_rank = new int[size];
			_parent = new int[size];
			for (var i = 0; i < size; i++)
			{
				_parent[i] = i;
			}
		}

		public int Find(int x)
		{
			if (_parent[x] != x)
			{
				_parent[x] = Find(_parent[x]);
			}
				
			return _parent[x];
		}

		public void Union(int x, int y)
		{
			x = Find(x);
			y = Find(y);
			if (x == y)
			{
				return;
			}
			else if (_rank[x] < _rank[y])
			{
				_parent[x] = y;
			}
			else if (_rank[x] > _rank[y])
			{
				_parent[y] = x;
			}
			else
			{
				_parent[y] = x;
				_rank[x]++;
			}
		}
	}

	public static int NumberOfGoodPaths(int[] vals, int[][] edges)
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

		var tree = new SortedDictionary<int, IList<int>>();
		for (var i = 0; i < vals.Length; i++)
		{
			if (!tree.ContainsKey(vals[i]))
			{
				tree[vals[i]] = new List<int>();
			}
			tree[vals[i]].Add(i);
		}

		var result = 0;

		var unionFind = new UnionFind(vals.Length);
		foreach (var key in tree.Keys)
		{
			foreach (var node in tree[key])
			{
				if (!adj.ContainsKey(node))
				{
					continue;
				}

				foreach (var neighbor in adj[node])
				{
					if (vals[node] >= vals[neighbor])
					{
						unionFind.Union(node, neighbor);
					}
				}
			}

			var group = new Dictionary<int, int>();
			foreach (var node in tree[key])
			{
				var found = unionFind.Find(node);
				if (!group.ContainsKey(found))
				{
					group[found] = 0;
				}
				group[found]++;
			}

			foreach (var groupKey in group.Keys)
			{
				var size = group[groupKey];
				result += size * (size + 1) / 2;
			}
		}

		return result;
	}
}
