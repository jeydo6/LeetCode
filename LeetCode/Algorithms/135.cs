using System;

namespace LeetCode.Algorithms;

// HARD
internal class _135
{
	public static int Candy(int[] ratings)
	{
		var candies = new int[ratings.Length];
		for (var i = 0; i < ratings.Length; i++)
		{
			candies[i] = 1;
		}

		for (var i = 1; i < ratings.Length; i++)
		{
			if (ratings[i] > ratings[i - 1])
			{
				candies[i] = candies[i - 1] + 1;
			}
		}

		var result = candies[ratings.Length - 1];
		for (var i = ratings.Length - 2; i >= 0; i--)
		{
			if (ratings[i] > ratings[i + 1])
			{
				candies[i] = Math.Max(candies[i], candies[i + 1] + 1);
			}
			result += candies[i];
		}
		return result;
	}
}
