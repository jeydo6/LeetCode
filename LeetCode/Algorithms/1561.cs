using System;

namespace LeetCode.Algorithms;

// MEDIUM
internal class _1561
{
	public static int MaxCoins(int[] piles)
	{
		Array.Sort(piles);

		var result = 0;
		for (var i = piles.Length / 3; i < piles.Length; i += 2)
		{
			result += piles[i];
		}

		return result;
	}
}