using System;
using System.Collections.Generic;

namespace LeetCode.Algorithms
{
	// MEDIUM
	internal class _39
	{
		public static IList<IList<int>> CombinationSum(int[] candidates, int target)
		{
			var list = new List<IList<int>>();
			Array.Sort(candidates);
			Backtrack(list, new List<int>(), candidates, target, 0);
			return list;
		}

		private static void Backtrack(IList<IList<int>> list, IList<int> temp, int[] candidates, int target, int start)
		{
			if (target < 0)
			{
				return;
			}
			else if (target == 0)
			{
				list.Add(new List<int>(temp));
			}
			else
			{
				for (var i = start; i < candidates.Length; i++)
				{
					temp.Add(candidates[i]);
					Backtrack(list, temp, candidates, target - candidates[i], i);
					temp.RemoveAt(temp.Count - 1);
				}
			}
		}
	}
}
