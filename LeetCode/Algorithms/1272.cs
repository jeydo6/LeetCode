using System.Collections.Generic;

namespace LeetCode.Algorithms;

// MEDIUM
internal class _1272
{
	public static IList<IList<int>> RemoveInterval(int[][] intervals, int[] toBeRemoved)
	{
		var result = new List<IList<int>>();
		foreach (var interval in intervals)
		{
			if (interval[0] > toBeRemoved[1] || interval[1] < toBeRemoved[0])
			{
				result.Add(new List<int> { interval[0], interval[1] });
			}
			else
			{
				if (interval[0] < toBeRemoved[0])
				{
					result.Add(new List<int> { interval[0], toBeRemoved[0] });
				}

				if (interval[1] > toBeRemoved[1])
				{
					result.Add(new List<int> { toBeRemoved[1], interval[1] });
				}
			}
		}

		return result;
	}
}
