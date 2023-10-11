using System;

namespace LeetCode.Algorithms;

// MEDIUM
internal class _881
{
	public static int NumRescueBoats(int[] people, int limit)
	{
		Array.Sort(people);
		var i = 0;
		var j = people.Length - 1;

		var result = 0;
		while (i <= j)
		{
			result++;
			if (people[i] + people[j] <= limit)
			{
				i++;
			}
			j--;
		}
		return result;
	}
}
