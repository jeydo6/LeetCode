using System.Collections.Generic;

namespace LeetCode.Algorithms;

// HARD
internal class _2251
{
	public static int[] FullBloomFlowers(int[][] flowers, int[] people)
	{
		var starts = new List<int>();
		var ends = new List<int>();

		for (var i = 0; i < flowers.Length; i++)
		{
			starts.Add(flowers[i][0]);
			ends.Add(flowers[i][1] + 1);
		}

		starts.Sort();
		ends.Sort();

		var result = new int[people.Length];
		for (var p = 0; p < people.Length; p++)
		{
			var person = people[p];
			var i = BinarySearch(starts, person);
			var j = BinarySearch(ends, person);
			result[p] = i - j;
		}

		return result;
	}

	private static int BinarySearch(IList<int> arr, int target)
	{
		var lo = 0;
		var hi = arr.Count;
		while (lo < hi)
		{
			var mid = lo + (hi - lo) / 2;
			if (target < arr[mid])
			{
				hi = mid;
			}
			else
			{
				lo = mid + 1;
			}
		}

		return lo;
	}
}
