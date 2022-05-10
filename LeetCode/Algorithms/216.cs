using System.Collections.Generic;

namespace LeetCode.Algorithms
{
	// MEDIUM
	internal class _216
	{
		public static IList<IList<int>> CombinationSum3(int k, int n)
		{
			var results = new List<IList<int>>();
			var combination = new Stack<int>();

			Backtrack(n, k, 0, combination, results);
			return results;
		}

		private static void Backtrack(int remain, int k, int nextStart, Stack<int> combination, IList<IList<int>> results)
		{
			if (remain == 0 && combination.Count == k)
			{
				results.Add(new List<int>(combination));
				return;
			}
			else if (remain < 0 || combination.Count == k)
			{
				return;
			}

			for (var i = nextStart; i < 9; i++)
			{
				combination.Push(i + 1);
				Backtrack(remain - i - 1, k, i + 1, combination, results);
				combination.Pop();
			}
		}
	}
}
