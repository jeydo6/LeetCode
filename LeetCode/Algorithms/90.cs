using System;
using System.Collections.Generic;

namespace LeetCode.Algorithms
{
	class _90
	{
		public static IList<IList<int>> SubsetsWithDup(int[] numbers)
		{
			Array.Sort(numbers);

			var result = new List<IList<int>>
			{
				new List<int>()
			};

			var count = 0;
			for (var i = 0; i < numbers.Length; i++)
			{
				var startIndex = (i >= 1 && numbers[i] == numbers[i - 1]) ? count : 0;
				count = result.Count;
				for (var j = startIndex; j < count; j++)
				{
					var temp = new List<int>(result[j])
					{
						numbers[i]
					};
					result.Add(temp);
				}
			}

			return result;
		}
	}
}
