using System.Collections.Generic;

namespace Leetcode.Algorithms
{
	// EASY
	internal class _961
	{
		public static int RepeatedNTimes(int[] numbers)
		{
			var hashSet = new HashSet<int>();
			foreach (int number in numbers)
			{
				if (hashSet.Contains(number))
				{
					return number;
				}
				else
				{
					hashSet.Add(number);
				}
			}
			return 0;
		}
	}
}
