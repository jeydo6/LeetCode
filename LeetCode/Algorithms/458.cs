using System;

namespace LeetCode.Algorithms;


// HARD
internal class _458
{
	public static int PoorPigs(int buckets, int minutesToDie, int minutesToTest)
	{
		var pigs = 0;
		while (Math.Pow(minutesToTest / minutesToDie + 1, pigs) < buckets)
		{
			pigs++;
		}
		return pigs;
	}
}