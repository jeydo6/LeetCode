using System;
using System.Collections.Generic;

namespace LeetCode.Algorithms;

// HARD
internal class _2136
{
	public static int EarliestFullBloom(int[] plantTime, int[] growTime)
	{
		var indices = new List<int>();
		for (var i = 0; i < growTime.Length; i++)
		{
			indices.Add(i);
		}

		indices.Sort((i1, i2) => growTime[i1] - growTime[i2]);

		var currentPlantTime = 0;
		var result = 0;
		for (var i = 0; i < growTime.Length; i++)
		{
			var index = indices[i];

			result = Math.Max(result, currentPlantTime + plantTime[index] + growTime[index]);

			currentPlantTime += plantTime[index];
		}

		return result;
	}
}
