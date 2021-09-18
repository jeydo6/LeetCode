using System;

namespace LeetCode.Algorithms
{
	class _1710
	{
		public static int MaximumUnits(int[][] boxTypes, int truckSize)
		{
			Array.Sort(boxTypes, (a, b) => b[1] - a[1]);
			
			var result = 0;
			foreach (var item in boxTypes)
			{
				if (item[0] < truckSize)
				{
					result += item[0] * item[1];
					truckSize -= item[0];
				}
				else
				{
					result += truckSize * item[1];
					return result;
				}
			}
			return result;
		}
	}
}
