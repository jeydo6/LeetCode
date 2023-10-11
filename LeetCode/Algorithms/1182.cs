using System;
using System.Collections.Generic;

namespace LeetCode.Algorithms
{
	// MEDIUM
	internal class _1182
	{
		public static IList<int> ShortestDistanceColor(int[] colors, int[][] queries)
		{
			var result = new List<int>();
			var dict = new Dictionary<int, List<int>>();

			for (var i = 0; i < colors.Length; i++)
			{
				var color = colors[i];
				if (!dict.ContainsKey(color))
				{
					dict[color] = new List<int>();
				}
				dict[color].Add(i);
			}

			for (var i = 0; i < queries.Length; i++)
			{
				var target = queries[i][0];
				var color = queries[i][1];
				if (!dict.ContainsKey(color))
				{
					result.Add(-1);
					continue;
				}

				var indexes = dict[color];
				var insert = indexes.BinarySearch(target);
				if (insert < 0)
				{
					insert = -(insert + 1);
				}

				if (insert == 0)
				{
					result.Add(
						indexes[insert] - target
					);
				}
				else if (insert == indexes.Count)
				{
					result.Add(
						target - indexes[insert - 1]
					);
				}
				else
				{
					result.Add(Math.Min(
						target - indexes[insert - 1],
						indexes[insert] - target
					));
				}

			}

			return result;
		}
	}
}
