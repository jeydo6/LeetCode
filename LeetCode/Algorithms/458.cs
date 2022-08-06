using System;

namespace LeetCode.Algorithms
{
	// HARD
	internal class _458
	{
		public static int PoorPigs(int buckets, int minutesToDie, int minutesToTest)
		{
			return (int)Math.Ceiling(
				Math.Log(buckets) / Math.Log(minutesToTest / minutesToDie + 1)
			);
		}
	}
}
