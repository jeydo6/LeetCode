using System.Collections.Generic;

namespace LeetCode.Algorithms;

// MEDIUM
internal class _1557
{
	public static IList<int> FindSmallestSetOfVertices(int n, IList<IList<int>> edges)
	{
		var isExists = new bool[n];
		foreach (var edge in edges)
		{
			isExists[edge[1]] = true;
		}

		var result = new List<int>();
		for (var i = 0; i < n; i++)
		{
			if (!isExists[i])
			{
				result.Add(i);
			}
		}
		return result;
	}
}
