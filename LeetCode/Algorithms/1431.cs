using System.Collections.Generic;
using System.Linq;

namespace LeetCode.Algorithms
{
	class _1431
	{
		public static IList<bool> KidsWithCandies(int[] candies, int extraCandies)
		{
			var max = candies.Max();
			return candies
				.Select(c => c + extraCandies >= max)
				.ToList();
		}
	}
}
