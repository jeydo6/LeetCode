using System;
using System.Collections.Generic;

namespace LeetCode.Algorithms;

// HARD
internal class _149
{
	public static int MaxPoints(int[][] points)
	{
		if (points.Length == 1)
		{
			return 1;
		}

		var result = 2;
		for (var i = 0; i < points.Length; i++)
		{
			var counts = new Dictionary<double, int>();
			for (var j = 0; j < points.Length; j++)
			{
				if (j != i)
				{
					var atan = Math.Atan2(points[j][1] - points[i][1], points[j][0] - points[i][0]);
					if (!counts.ContainsKey(atan))
					{
						counts[atan] = 1;
					}
					counts[atan]++;
				}
			}

			var maxCount = int.MinValue;
			foreach (var count in counts.Values)
			{
				if (count > maxCount)
				{
					maxCount = count;
				}
			}
			result = Math.Max(result, maxCount);
		}

		return result;
	}
}
