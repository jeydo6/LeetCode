using System.Collections.Generic;

namespace LeetCode.Algorithms
{
	// EASY
	internal class _728
	{
		public static IList<int> SelfDividingNumbers(int left, int right)
		{
			var result = new List<int>();

			while (left <= right)
			{
				var number = left;
				while (number > 0)
				{
					var r = number % 10;
					if (r == 0 || left % r != 0)
					{
						break;
					}
					number /= 10;
				}

				if (number == 0)
				{
					result.Add(left);
				}

				left++;
			}

			return result;
		}
	}
}