using System.Collections.Generic;

namespace LeetCode.Algorithms
{
	class _1389
	{
		public static int[] CreateTargetArray(int[] numbers, int[] index)
		{
			var result = new List<int>(numbers.Length);
			for (var i = 0; i < numbers.Length; i++)
			{
				if (index[i] > result.Count)
				{
					result.Add(numbers[i]);
				}
				else
				{
					result.Insert(index[i], numbers[i]);
				}
			}
			return result.ToArray();
		}
	}
}
