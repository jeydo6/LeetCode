using System;
using System.Collections.Generic;

namespace LeetCode.Algorithms
{
	// MEDIUM
	internal class _986
	{
		public static int[][] IntervalIntersection(int[][] firstList, int[][] secondList)
		{
			if (firstList == null || firstList.Length == 0 || secondList == null || secondList.Length == 0)
			{
				return Array.Empty<int[]>();
			}

			var result = new List<int[]>();

			int i = 0;
			var j = 0;
			while (i < firstList.Length && j < secondList.Length)
			{
				var startMax = Math.Max(firstList[i][0], secondList[j][0]);
				var endMin = Math.Min(firstList[i][1], secondList[j][1]);

				if (endMin >= startMax)
				{
					result.Add(new int[] { startMax, endMin });
				}

				if (firstList[i][1] == endMin)
				{
					i++;
				}
				if (secondList[j][1] == endMin)
				{
					j++;
				}
			}

			return result.ToArray();
		}
	}
}
