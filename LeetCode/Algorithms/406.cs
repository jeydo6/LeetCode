using System;
using System.Collections.Generic;

namespace LeetCode.Algorithms
{
	// MEDIUM
	internal class _406
	{
		public static int[][] ReconstructQueue(int[][] people)
		{
			Array.Sort(people, (p1, p2) => p1[0] == p2[0] ? p1[1] - p2[1] : p2[0] - p1[0]);

			var result = new List<int[]>();
			for (var i = 0; i < people.Length; i++)
			{
				result.Insert(people[i][1], people[i]);
			}

			return result.ToArray();
		}
	}
}
