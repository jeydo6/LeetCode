using System.Collections.Generic;

namespace LeetCode.Algorithms;

// MEDIUM
internal class _658
{
	public static IList<int> FindClosestElements(int[] arr, int k, int x)
	{
		var lo = 0;
		var hi = arr.Length - k;

		while (lo < hi)
		{
			var mid = (lo + hi) / 2;
			if (x - arr[mid] > arr[mid + k] - x)
			{
				lo = mid + 1;
			}
			else
			{
				hi = mid;
			}
		}

		var result = new List<int>();
		for (var i = lo; i < lo + k; i++)
		{
			result.Add(arr[i]);
		}

		return result;
	}
}
