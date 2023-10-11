using System;

namespace LeetCode.Algorithms;

// HARD
internal class _1697
{
	private class UnionFind
	{
		private readonly int[] _group;
		private readonly int[] _rank;

		public UnionFind(int size)
		{
			_group = new int[size];
			_rank = new int[size];
			for (var i = 0; i < size; i++)
			{
				_group[i] = i;
			}
		}

		public int Find(int node)
		{
			if (_group[node] != node)
			{
				_group[node] = Find(_group[node]);
			}
			return _group[node];
		}

		public void Join(int node1, int node2)
		{
			var group1 = Find(node1);
			var group2 = Find(node2);

			if (group1 == group2)
			{
				return;
			}

			if (_rank[group1] > _rank[group2])
			{
				_group[group2] = group1;
			}
			else if (_rank[group1] < _rank[group2])
			{
				_group[group1] = group2;
			}
			else
			{
				_group[group1] = group2;
				_rank[group2] += 1;
			}
		}

		public bool AreConnected(int node1, int node2)
		{
			var group1 = Find(node1);
			var group2 = Find(node2);
			return group1 == group2;
		}
	};

	public static bool[] DistanceLimitedPathsExist(int n, int[][] edgeList, int[][] queries)
	{
		var uf = new UnionFind(n);
		var result = new bool[queries.Length];

		var queriesWithIndex = new int[queries.Length][];
		for (var i = 0; i < queriesWithIndex.Length; i++)
		{
			queriesWithIndex[i] = new int[]
			{
				queries[i][0],
				queries[i][1],
				queries[i][2],
				i
			};
		}

		Array.Sort(edgeList, (arr1, arr2) => arr1[2] - arr2[2]);
		Array.Sort(queriesWithIndex, (arr1, arr2) => arr1[2] - arr2[2]);
		
		var edgesIndex = 0;
		for (var queryIndex = 0; queryIndex < queriesWithIndex.Length; queryIndex += 1)
		{
			var p = queriesWithIndex[queryIndex][0];
			var q = queriesWithIndex[queryIndex][1];
			var limit = queriesWithIndex[queryIndex][2];
			var queryOriginalIndex = queriesWithIndex[queryIndex][3];

			while (edgesIndex < edgeList.Length && edgeList[edgesIndex][2] < limit)
			{
				var node1 = edgeList[edgesIndex][0];
				var node2 = edgeList[edgesIndex][1];
				uf.Join(node1, node2);
				edgesIndex += 1;
			}

			result[queryOriginalIndex] = uf.AreConnected(p, q);
		}

		return result;
	}
}
