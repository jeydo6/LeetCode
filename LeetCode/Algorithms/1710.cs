using System;

namespace LeetCode.Algorithms
{
	// EASY
	internal class _1710
	{
		public static int MaximumUnits(int[][] boxTypes, int truckSize)
		{
			Array.Sort(boxTypes, (a, b) => b[1] - a[1]);

			var result = 0;
			for (var i = 0; i < boxTypes.Length; i++)
			{
				var boxCount = Math.Min(truckSize, boxTypes[i][0]);
				result += boxCount * boxTypes[i][1];
				truckSize -= boxCount;

				if (truckSize == 0)
				{
					break;
				}
			}
			return result;
		}
	}
}
