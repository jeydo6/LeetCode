using System;

namespace LeetCode.Algorithms
{
	// MEDIUM
	internal class _973
	{
		public static int[][] KClosest(int[][] points, int k)
		{
			Array.Sort(points, (p1, p2) => p1[0] * p1[0] + p1[1] * p1[1] - p2[0] * p2[0] - p2[1] * p2[1]);
			var result = new int[k][];
			Array.Copy(points, result, k);
			return result;
		}
	}
}
