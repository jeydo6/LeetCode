using System;
using System.Collections.Generic;

namespace LeetCode.Algorithms;

// HARD
internal class _1383
{
	private const int Modulo = 1_000_000_007;

	public static int MaxPerformance(int n, int[] speed, int[] efficiency, int k)
	{
		var candidates = new List<(int Efficiency, int Speed)>();
		for (var i = 0; i < n; i++)
		{
			candidates.Add((efficiency[i], speed[i]));
		}

		candidates.Sort((o1, o2) => o1.Efficiency - o2.Efficiency);

		var speedHeap = new PriorityQueue<int, int>();

		var speedSum = 0L;
		var maxPerformance = 0L;
		for (var i = 0; i < candidates.Count; i++)
		{
			var (currentEfficiency, currentSpeed) = candidates[i];
			if (speedHeap.Count > k - 1)
			{
				speedSum -= speedHeap.Dequeue();
			}
			speedHeap.Enqueue(currentSpeed, currentSpeed);

			speedSum += currentSpeed;
			maxPerformance = Math.Max(maxPerformance, speedSum * currentEfficiency);
		}
		return (int)(maxPerformance % Modulo);
	}
}
