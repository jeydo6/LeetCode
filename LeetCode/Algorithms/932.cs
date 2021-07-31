using System.Collections.Generic;
using System.Linq;

namespace LeetCode.Algorithms
{
	class _932
	{
		public static int[] BeautifulArray(int n)
		{
			var result = new List<int> { 1 };

			while (result.Count < n)
			{
				result = Enumerable
					.Concat(
						result.Select(i => i * 2 - 1),
						result.Select(i => i * 2)
					)
					.ToList();
			}

			return result
				.Where(i => i <= n)
				.ToArray();
		}
	}
}
