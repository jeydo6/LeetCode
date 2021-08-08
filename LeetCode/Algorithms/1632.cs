using System;
using System.Collections.Generic;

namespace LeetCode.Algorithms
{
	// HARD
	class _1632
	{
		public static int[][] MatrixRankTransform(int[][] matrix)
		{
			var n = matrix.Length;
			var m = matrix[0].Length;

			var dict = new Dictionary<int, List<(int X, int Y)>>();
			for (var i = 0; i < n; i++)
			{
				for (var j = 0; j < m; j++)
				{
					var key = matrix[i][j];
					var value = (X: i, Y: j);
					if (dict.ContainsKey(key))
					{
						dict[key].Add(value);
					}
					else
					{
						dict[key] = new List<(int X, int Y)>
						{
							value
						};
					}
				}
			}

			var rank = new int[n + m];
			var keys = new int[dict.Keys.Count];
			dict.Keys.CopyTo(keys, 0);
			Array.Sort(keys);
			foreach (var key in keys)
			{
				var root = new int[n + m];
				for (var i = 0; i < n + m; i++)
				{
					root[i] = i;
				}

				var temp = new int[n + m];
				rank.CopyTo(temp, 0);
				foreach (var (x, y) in dict[key])
				{
					var i = Find(root, x);
					var j = Find(root, n + y);
					root[i] = j;
					temp[j] = Math.Max(temp[i], temp[j]);
				}
				foreach (var (x, y) in dict[key])
				{
					matrix[x][y] = temp[Find(root, x)] + 1;
					rank[n + y] = temp[Find(root, x)] + 1;
					rank[x] = temp[Find(root, x)] + 1;
				}
			}
			return matrix;
		}

		private static int Find(int[] root, int value)
		{
			if (root[value] != value)
			{
				root[value] = Find(root, root[value]);
			}
			return root[value];
		}
	}
}
