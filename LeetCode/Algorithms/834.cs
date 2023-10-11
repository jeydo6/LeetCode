using System.Collections.Generic;

namespace LeetCode.Algorithms
{
	// HARD
	internal class _834
	{
		private int[] _result;
		private int[] _count;

		private List<HashSet<int>> _tree;

		public int[] SumOfDistancesInTree(int n, int[][] edges)
		{
			_result = new int[n];
			_count = new int[n];

			_tree = new List<HashSet<int>>();
			for (var i = 0; i < n; i++)
			{
				_tree.Add(new HashSet<int>());
			}
			foreach (var edge in edges)
			{
				_tree[edge[0]].Add(edge[1]);
				_tree[edge[1]].Add(edge[0]);
			}

			DFS1(0, -1);
			DFS2(0, -1);

			return _result;
		}

		private void DFS1(int root, int val)
		{
			foreach (var node in _tree[root])
			{
				if (node == val)
				{
					continue;
				}
				DFS1(node, root);
				_count[root] += _count[node];
				_result[root] += _result[node] + _count[node];
			}
			_count[root]++;
		}

		private void DFS2(int root, int val)
		{
			foreach (var node in _tree[root])
			{
				if (node == val)
				{
					continue;
				}
				_result[node] = _result[root] - _count[node] + _count.Length - _count[node];
				DFS2(node, root);
			}
		}
	}
}
