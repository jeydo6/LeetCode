using System;
using System.Collections.Generic;

namespace LeetCode.Algorithms;

// MEDIUM
internal class _1066
{
	public static int AssignBikes(int[][] workers, int[][] bikes)
	{
		var memo = new int[1024];
		for (var i = 0; i < memo.Length; i++)
		{
			memo[i] = int.MaxValue;
		}
		memo[0] = 0;

		return AssignBikes(workers, bikes, memo);
	}

	private static int AssignBikes(int[][] workers, int[][] bikes, int[] memo)
	{
		var result = int.MaxValue;
		for (var mask = 0; mask < (1 << bikes.Length); mask++)
		{
			int nextWorkerIndex = CountNumOfOnes(mask);

			if (nextWorkerIndex >= workers.Length)
			{
				result = Math.Min(result, memo[mask]);
				continue;
			}

			for (var bikeIndex = 0; bikeIndex < bikes.Length; bikeIndex++)
			{
				if ((mask & (1 << bikeIndex)) == 0)
				{
					var newMask = (1 << bikeIndex) | mask;
					memo[newMask] = Math.Min(memo[newMask], memo[mask] + FindDistance(workers[nextWorkerIndex], bikes[bikeIndex]));
				}
			}
		}

		return result;
	}

	private static int FindDistance(int[] worker, int[] bike)
	{
		return Math.Abs(worker[0] - bike[0]) + Math.Abs(worker[1] - bike[1]);
	}

	private static int CountNumOfOnes(int mask)
	{
		var count = 0;
		while (mask != 0)
		{
			mask &= (mask - 1);
			count++;
		}
		return count;
	}
}
