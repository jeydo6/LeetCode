using System;

namespace LeetCode.Algorithms
{
	// MEDIUM
	internal class _1689
	{
		public static int MinPartitions(string n)
		{
			var max = 0;
			for (int i = 0; i < n.Length; i++)
			{
				max = Math.Max(max, n[i] - '0');
			}
			return max;
		}
	}
}
