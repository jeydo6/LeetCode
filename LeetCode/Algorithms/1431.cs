using System.Collections.Generic;

namespace LeetCode.Algorithms;

// EASY
internal class _1431
{
	public static IList<bool> KidsWithCandies(int[] candies, int extraCandies)
	{
		var maxCandies = candies[0];
		for (var i = 1; i < candies.Length; i++)
		{
			if (candies[i] > maxCandies)
			{
				maxCandies = candies[i];
			}
		}

		var result = new List<bool>(candies.Length);
		for (var i = 0; i < candies.Length; i++)
		{
			result.Add(candies[i] + extraCandies >= maxCandies);
		}
		return result;
	}
}
