using System;
using System.Collections.Generic;

namespace LeetCode.Algorithms;

// HARD
internal class _1489
{
	private class UnionFind
	{
		private readonly int[] _parent;
		private readonly int[] _size;

		public UnionFind(int n)
		{
			_parent = new int[n];
			_size = new int[n];
			for (int i = 0; i < n; i++)
			{
				_parent[i] = i;
				_size[i] = 1;
			}
			MaxSize = 1;
		}

		public int Find(int x)
		{
			if (x != _parent[x])
			{
				_parent[x] = Find(_parent[x]);
			}
			return _parent[x];
		}

		public bool Union(int x, int y)
		{
			var rootX = Find(x);
			var rootY = Find(y);
			if (rootX != rootY)
			{
				if (_size[rootX] < _size[rootY])
				{
					(rootX, rootY) = (rootY, rootX);
				}
				_parent[rootY] = rootX;
				_size[rootX] += _size[rootY];
				
				MaxSize = Math.Max(MaxSize, _size[rootX]);
				return true;
			}
			return false;
		}

		public int MaxSize { get; private set; }
	}

	public static IList<IList<int>> FindCriticalAndPseudoCriticalEdges(int n, int[][] edges)
	{
		var newEdges = new int[edges.Length][];
		for (var i = 0; i < newEdges.Length; i++)
		{
			newEdges[i] = new int[4];
			for (var j = 0; j < newEdges[i].Length - 1; j++)
			{
				newEdges[i][j] = edges[i][j];
			}
			newEdges[i][^1] = i;
		}

		Array.Sort(newEdges, (e1, e2) => e1[2] - e2[2]);

		var ufStd = new UnionFind(n);
		var stdWeight = 0;
		for (var i = 0; i < newEdges.Length; i++)
		{
			if (ufStd.Union(newEdges[i][0], newEdges[i][1]))
			{
				stdWeight += newEdges[i][2];
			}
		}

		var result = new List<IList<int>>
		{
			new List<int>(),
			new List<int>()
		};

		for (var i = 0; i < newEdges.Length; i++)
		{
			var ufIgnore = new UnionFind(n);
			var ignoreWeight = 0;
			for (var j = 0; j < newEdges.Length; j++)
			{
				if (i != j && ufIgnore.Union(newEdges[j][0], newEdges[j][1]))
				{
					ignoreWeight += newEdges[j][2];
				}
			}

			if (ufIgnore.MaxSize < n || ignoreWeight > stdWeight)
			{
				result[0].Add(newEdges[i][3]);
			}
			else
			{
				var ufForce = new UnionFind(n);
				ufForce.Union(newEdges[i][0], newEdges[i][1]);
				var forceWeight = newEdges[i][2];
				for (var j = 0; j < newEdges.Length; j++)
				{
					if (i != j && ufForce.Union(newEdges[j][0], newEdges[j][1]))
					{
						forceWeight += newEdges[j][2];
					}
				}

				if (forceWeight == stdWeight)
				{
					result[1].Add(newEdges[i][3]);
				}
			}
		}

		return result;
	}
}
