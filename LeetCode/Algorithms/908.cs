using System;

namespace LeetCode.Algorithms
{
	// EASY
	internal class _908
	{
		public static int SmallestRangeI(int[] arr, int k)
		{
			var min = arr[0];
			var max = arr[0];

			foreach (var item in arr)
			{
				min = Math.Min(min, item);
				max = Math.Max(max, item);
			}

			return Math.Max(0, max - min - 2 * k);
		}
	}
}
