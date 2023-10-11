using System.Collections.Generic;

namespace LeetCode.Algorithms;

// MEDIUM
internal class _2244
{
	public static int MinimumRounds(int[] tasks)
	{
		var frequncies = new Dictionary<int, int>();
		for (var i = 0; i < tasks.Length; i++)
		{
			var task = tasks[i];
			if (!frequncies.ContainsKey(task))
			{
				frequncies[task] = 0;
			}
			frequncies[task]++;
		}

		var result = 0;
		foreach (var count in frequncies.Values)
		{
			if (count == 1)
			{
				return -1;
			}

			if (count % 3 == 0)
			{
				result += count / 3;
			}
			else
			{
				result += count / 3 + 1;
			}
		}

		return result;
	}
}
