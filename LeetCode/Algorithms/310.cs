using System.Collections.Generic;

namespace LeetCode.Algorithms
{
	// MEDIUM
	internal class _310
	{
		public static IList<int> FindMinHeightTrees(int n, int[][] edges)
		{
			if (n == 1)
			{
				return new List<int> { 0 };
			}

			var adj = new List<ISet<int>>();
			for (var i = 0; i < n; i++)
			{
				adj.Add(new HashSet<int>());
			}
			for (var i = 0; i < edges.Length; i++)
			{
				var edge = edges[i];
				adj[edge[0]].Add(edge[1]);
				adj[edge[1]].Add(edge[0]);
			}

			var leaves = new List<int>();
			for (var i = 0; i < n; i++)
			{
				if (adj[i].Count == 1)
				{
					leaves.Add(i);
				}
			}

			while (n > 2)
			{
				n -= leaves.Count;
				var temp = new List<int>();
				foreach (var i in leaves)
				{
					var enumerator = adj[i].GetEnumerator();
					enumerator.MoveNext();
					var j = enumerator.Current;

					adj[j].Remove(i);
					if (adj[j].Count == 1)
					{
						temp.Add(j);
					}
				}
				leaves = temp;
			}
			return leaves;
		}
	}
}
