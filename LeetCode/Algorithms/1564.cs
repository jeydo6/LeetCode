using System;

namespace LeetCode.Algorithms
{
	// MEDIUM
	internal class _1564
	{
		public static int MaxBoxesInWarehouse(int[] boxes, int[] warehouse)
		{
			for (var i = 1; i < warehouse.Length; i++)
			{
				warehouse[i] = Math.Min(warehouse[i - 1], warehouse[i]);
			}

			Array.Sort(boxes);

			var result = 0;
			for (var i = warehouse.Length - 1; i >= 0; i--)
			{
				if (result < boxes.Length && boxes[result] <= warehouse[i])
				{
					result++;
				}
			}

			return result;
		}
	}
}
