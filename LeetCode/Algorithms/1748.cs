using System.Collections.Generic;

namespace LeetCode.Algorithms
{
	class _1748
	{
		public static int SumOfUnique(int[] numbers)
		{
			var dict = new Dictionary<int, int>();
			foreach (int number in numbers)
			{
				if (!dict.ContainsKey(number))
				{
					dict[number] = 0;
				}
				dict[number]++;
			}

			var result = 0;
			foreach (var key in dict.Keys)
			{
				if (dict[key] == 1)
				{
					result += key;
				}
			}
			return result;
		}
	}
}
