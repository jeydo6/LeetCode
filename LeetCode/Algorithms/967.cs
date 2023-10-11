using System.Collections.Generic;

namespace LeetCode.Algorithms
{
	// MEDIUM
	internal class _967
	{
		public static int[] NumsSameConsecDiff(int n, int k)
		{
			var result = new List<int> { 1, 2, 3, 4, 5, 6, 7, 8, 9 };

			for (var i = 2; i <= n; i++)
			{
				var temp = new List<int>();
				for (var j = 0; j < result.Count; j++)
				{
					var digit = result[j] % 10;
					if (digit + k < 10)
					{
						temp.Add(result[j] * 10 + digit + k);
					}

					if (k > 0 && digit - k >= 0)
					{
						temp.Add(result[j] * 10 + digit - k);
					}
				}
				result = temp;
			}

			return result.ToArray();
		}
	}
}
