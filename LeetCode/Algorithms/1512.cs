using System.Collections.Generic;

namespace LeetCode.Algorithms
{
	class _1512
	{
		//public static int NumIdenticalPairs(int[] numbers)
		//{
		//	var result = 0;
		//	for (var i = 0; i < numbers.Length - 1; i++)
		//	{
		//		for (var j = i + 1; j < numbers.Length; j++)
		//		{
		//			if (numbers[i] == numbers[j])
		//			{
		//				result++;
		//			}
		//		}
		//	}
		//	return result;
		//}

		public static int NumIdenticalPairs(int[] numbers)
		{
			var dict = new Dictionary<int, int>();
			foreach (var number in numbers)
			{
				if (dict.ContainsKey(number))
				{
					dict[number]++;
				}
				else
				{
					dict[number] = 1;
				}
			}

			var result = 0;
			foreach (var key in dict.Keys)
			{
				var value = dict[key];
				result += value * (value - 1) / 2;
			}
			return result;
		}
	}
}
