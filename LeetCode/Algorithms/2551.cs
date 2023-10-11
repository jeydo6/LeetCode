using System;

namespace LeetCode.Algorithms;

// HARD
internal class _2551
{
	public static long PutMarbles(int[] weights, int k)
	{
		var n = weights.Length;
		var pairWeights = new int[n - 1];
		for (var i = 0; i < n - 1; i++)
		{
			pairWeights[i] = weights[i] + weights[i + 1];
		}

		Array.Sort(pairWeights, 0, n - 1);

		var result = 0L;
		for (var i = 0; i < k - 1; i++)
		{
			result += pairWeights[n - 2 - i] - pairWeights[i];
		}

		return result;
	}
}