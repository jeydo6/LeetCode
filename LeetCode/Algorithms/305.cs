using System.Collections.Generic;

namespace LeetCode.Algorithms;

// HARD
internal class _305
{
	private class UnionFind
	{
		private readonly int[] _parent;
		private readonly int[] _rank;
		
		private int _count;

		public UnionFind(int size)
		{
			_rank = new int[size];
			_parent = new int[size];
			for (var i = 0; i < size; i++)
			{
				_parent[i] = -1;
			}
		}

		public void AddLand(int x)
		{
			if (IsLand(x))
			{
				return;
			}

			_parent[x] = x;
			_count++;
		}

		public bool IsLand(int x)
		{
			if (_parent[x] >= 0)
			{
				return true;
			}
			else
			{
				return false;
			}
		}

		public int NumberOfIslands()
		{
			return _count;
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
			var xSet = Find(x);
			var ySet = Find(y);
			if (xSet == ySet)
			{
				return;
			}
			else if (_rank[xSet] < _rank[ySet])
			{
				_parent[xSet] = ySet;
			}
			else if (_rank[xSet] > _rank[ySet])
			{
				_parent[ySet] = xSet;
			}
			else
			{
				_parent[ySet] = xSet;
				_rank[xSet]++;
			}
			_count--;
		}
	}

	public static IList<int> NumIslands2(int m, int n, int[][] positions)
	{
		var x = new int[] { -1, 1, 0, 0 };
		var y = new int[] { 0, 0, -1, 1 };
		var dsu = new UnionFind(m * n);
		var result = new List<int>();
		for (var i = 0; i < positions.Length; i++)
		{
			var landPosition = positions[i][0] * n + positions[i][1];
			dsu.AddLand(landPosition);

			for (var j = 0; j < 4; j++)
			{
				var neighborX = positions[i][0] + x[j];
				var neighborY = positions[i][1] + y[j];
				var neighborPosition = neighborX * n + neighborY;
				if (neighborX >= 0 && neighborX < m && neighborY >= 0 && neighborY < n && dsu.IsLand(neighborPosition))
				{
					dsu.Union(landPosition, neighborPosition);
				}
			}
			result.Add(dsu.NumberOfIslands());
		}
		return result;
	}
}
