using System.Collections.Generic;

namespace LeetCode.Algorithms;

// MEDIUM
internal class _46
{
	public static IList<IList<int>> Permute(int[] nums, List<int> current = null)
	{
		if (current == null)
		{
			current = new List<int>();
		}

		var result = new List<IList<int>>();
		if (current.Count == nums.Length)
		{
			result.Add(new List<int>(current));
		}
		else
		{
			for (var i = 0; i < nums.Length; i++)
			{
				if (current.Contains(nums[i]))
				{
					continue;
				}

				current.Add(nums[i]);
				var temp = Permute(nums, current);
				foreach (var combination in temp)
				{
					result.Add(combination);
				}
				current.RemoveAt(current.Count - 1);
			}
		}
		return result;
	}
}