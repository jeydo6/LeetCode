using System;
using System.Collections.Generic;

namespace LeetCode.Algorithms;

// MEDIUM
internal class _904
{
	public static int TotalFruit(int[] fruits)
	{
		var basket = new Dictionary<int, int>();

		var left = 0;
		var right = 0;

		var result = 0;
		while (right < fruits.Length)
		{
			if (!basket.ContainsKey(fruits[right]))
			{
				basket[fruits[right]] = 0;
			}
			basket[fruits[right]]++;

			while (basket.Count > 2)
			{
				basket[fruits[left]]--;

				if (basket[fruits[left]] == 0)
				{
					basket.Remove(fruits[left]);
				}

				left++;
			}

			result = Math.Max(result, right - left + 1);
			right++;
		}

		return result;
	}
}
