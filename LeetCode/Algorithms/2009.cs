using System;
using System.Collections.Generic;

namespace LeetCode.Algorithms;

// HARD
internal class _2009
{
	public static int MinOperations(int[] nums)
	{
		var hashSet = new HashSet<int>(nums);
		var newNums = new int[hashSet.Count];

		var index = 0;
		foreach (var num in hashSet)
		{
			newNums[index++] = num;
		}

		Array.Sort(newNums);

		var result = nums.Length;

		var j = 0;
		for (var i = 0; i < newNums.Length; i++)
		{
			while (j < newNums.Length && newNums[j] < newNums[i] + nums.Length)
			{
				j++;
			}

			var count = j - i;
			result = Math.Min(result, nums.Length - count);
		}

		return result;
	}
}
