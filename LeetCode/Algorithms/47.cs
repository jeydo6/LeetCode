using System.Collections.Generic;

namespace LeetCode.Algorithms
{
	// MEDIUM
	internal class _47
	{
		public static IList<IList<int>> PermuteUnique(int[] nums)
		{
			var result = new List<IList<int>>();

			var counter = new Dictionary<int, int>();
			for (var i = 0; i < nums.Length; i++)
			{
				if (!counter.ContainsKey(nums[i]))
				{
					counter[nums[i]] = 0;
				}
				counter[nums[i]]++;
			}

			var combination = new LinkedList<int>();
			Backtrack(combination, nums.Length, counter, result);
			return result;
		}

		private static void Backtrack(LinkedList<int> combination, int n, IDictionary<int, int> counter, IList<IList<int>> result)
		{

			if (combination.Count == n)
			{
				result.Add(new List<int>(combination));
				return;
			}

			foreach (var (num, count) in counter)
			{

				if (count == 0)
				{
					continue;
				}

				combination.AddLast(num);
				counter[num] = count - 1;

				Backtrack(combination, n, counter, result);

				combination.RemoveLast();
				counter[num] = count;
			}
		}
	}
}