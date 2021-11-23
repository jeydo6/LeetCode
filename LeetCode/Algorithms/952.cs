using System.Collections.Generic;
using System.Linq;

namespace LeetCode.Algorithms
{
	// HARD
	internal class _952
	{
		public static int LargestComponentSize(int[] nums)
		{
			var parents = new int[nums.Length];
			var parentByDivisor = new Dictionary<int, int>();

			for (var i = 0; i < nums.Length; i++)
			{
				parents[i] = i;
				var divs = GetUniqueDivisors(nums[i]);

				foreach (var divisor in divs)
				{
					if (parentByDivisor.TryGetValue(divisor, out var p))
					{
						var root = FindParent(parents, p);
						parents[root] = i;
					}
					parentByDivisor[divisor] = i;
				}
			}

			var count = new int[nums.Length];
			for (var i = 0; i < nums.Length; i++)
			{
				var root = FindParent(parents, i);
				count[root]++;
			}

			return count.Max();
		}

		private static int FindParent(int[] parents, int i)
		{
			if (parents[i] != i)
			{
				parents[i] = FindParent(parents, parents[i]);
			}

			return parents[i];
		}

		private static HashSet<int> GetUniqueDivisors(int x)
		{
			var result = new HashSet<int>();

			while (x % 2 == 0)
			{
				result.Add(2);
				x >>= 1;
			}

			for (var i = 3; i * i <= x; i += 2)
			{
				while (x % i == 0)
				{
					result.Add(i);
					x /= i;
				}
			}

			if (x > 1) result.Add(x);

			return result;
		}
	}
}
