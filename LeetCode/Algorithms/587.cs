using System;
using System.Collections.Generic;

namespace LeetCode.Algorithms;

// HARD
internal class _587
{
	public static int[][] OuterTrees(int[][] trees)
	{
		Array.Sort(trees, (p, q) => q[0] - p[0] == 0 ? q[1] - p[1] : q[0] - p[0]);

		var list = new LinkedList<int[]>();
		for (var i = 0; i < trees.Length; i++)
		{
			while (list.Count >= 2 && Orientation(list.Last.Value, list.Last.Previous.Value, trees[i]) > 0)
			{
				list.RemoveLast();
			}
			list.AddLast(trees[i]);
		}

		list.RemoveLast();

		for (var i = trees.Length - 1; i >= 0; i--)
		{
			while (list.Count >= 2 && Orientation(list.Last.Value, list.Last.Previous.Value, trees[i]) > 0)
			{
				list.RemoveLast();
			}
			list.AddLast(trees[i]);
		}

		var result = new List<int[]>(list.Count);
		foreach (var item in new HashSet<int[]>(list))
		{
			result.Add(item);
		}
		return result.ToArray();
	}

	private static int Orientation(int[] p, int[] q, int[] r)
	{
		return (q[1] - p[1]) * (r[0] - q[0]) - (q[0] - p[0]) * (r[1] - q[1]);
	}
}
