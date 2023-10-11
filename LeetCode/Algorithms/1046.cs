using System;

namespace Leetcode.Algorithms
{
	// EASY
	internal class _1046
	{
		public static int LastStoneWeight(int[] stones)
		{
			var maxWeight = stones[0];
			for (var i = 0; i < stones.Length; i++)
			{
				maxWeight = Math.Max(maxWeight, stones[i]);
			}

			var buckets = new int[maxWeight + 1];
			for (var i = 0; i < stones.Length; i++)
			{
				buckets[stones[i]]++;
			}

			var biggestWeight = 0;
			var currentWeight = maxWeight;
			while (currentWeight > 0)
			{
				if (buckets[currentWeight] == 0)
				{
					currentWeight--;
				}
				else if (biggestWeight == 0)
				{
					buckets[currentWeight] %= 2;
					if (buckets[currentWeight] == 1)
					{
						biggestWeight = currentWeight;
					}
					currentWeight--;
				}
				else
				{
					buckets[currentWeight]--;
					if (biggestWeight - currentWeight <= currentWeight)
					{
						buckets[biggestWeight - currentWeight]++;
						biggestWeight = 0;
					}
					else
					{
						biggestWeight -= currentWeight;
					}
				}
			}
			return biggestWeight;
		}
	}
}
