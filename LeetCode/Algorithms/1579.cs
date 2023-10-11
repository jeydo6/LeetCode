namespace LeetCode.Algorithms;

// HARD
internal class _1579
{
	private class UnionFind
	{
		private readonly int[] _representatives;
		private readonly int[] _componentSizes;

		int _components;

		public UnionFind(int n)
		{
			_components = n;
			_representatives = new int[n + 1];
			_componentSizes = new int[n + 1];

			for (var i = 0; i <= n; i++)
			{
				_representatives[i] = i;
				_componentSizes[i] = 1;
			}
		}

		public int Find(int x)
		{
			if (_representatives[x] == x)
			{
				return x;
			}

			return _representatives[x] = Find(_representatives[x]);
		}

		public int Union(int x, int y)
		{
			x = Find(x);
			y = Find(y);

			if (x == y)
			{
				return 0;
			}

			if (_componentSizes[x] > _componentSizes[y])
			{
				_componentSizes[x] += _componentSizes[y];
				_representatives[y] = x;
			}
			else
			{
				_componentSizes[y] += _componentSizes[x];
				_representatives[x] = y;
			}

			_components--;
			return 1;
		}

		public bool IsConnected()
		{
			return _components == 1;
		}
	}

	public static int MaxNumEdgesToRemove(int n, int[][] edges)
	{
		var uf1 = new UnionFind(n);
		var uf2 = new UnionFind(n);

		var edgesRequired = 0;
		for (var i = 0; i < edges.Length; i++)
		{
			if (edges[i][0] == 3)
			{
				edgesRequired += uf1.Union(edges[i][1], edges[i][2]) | uf2.Union(edges[i][1], edges[i][2]);
			}
		}
		for (var i = 0; i < edges.Length; i++)
		{
			if (edges[i][0] == 1)
			{
				edgesRequired += uf1.Union(edges[i][1], edges[i][2]);
			}
			else if (edges[i][0] == 2)
			{
				edgesRequired += uf2.Union(edges[i][1], edges[i][2]);
			}
		}

		if (uf1.IsConnected() && uf2.IsConnected())
		{
			return edges.Length - edgesRequired;
		}

		return -1;
	}
}
