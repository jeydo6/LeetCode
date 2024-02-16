using System;
using System.Collections.Generic;

namespace LeetCode.Algorithms;

// MEDIUM
internal sealed class _1481
{
	public static int FindLeastNumOfUniqueInts(int[] arr, int k)
	{
		var dict = new Dictionary<int, int>();
		for (var i = 0; i < arr.Length; i++)
		{
			dict.TryAdd(arr[i], 0);
			dict[arr[i]]++;
		}

		var countOfFrequencies = new int[arr.Length + 1];
		foreach (var value in dict.Values)
		{
			countOfFrequencies[value]++;
		}

		var remainingUniqueElements = dict.Count;
		for (var i = 1; i < countOfFrequencies.Length; i++)
		{
			var numElementsToRemove = Math.Min(k / i, countOfFrequencies[i]);
			
			k -= i * numElementsToRemove;
			remainingUniqueElements -= numElementsToRemove;

			if (k < i) {
				return remainingUniqueElements;
			}
		}

		return 0;
	}
}