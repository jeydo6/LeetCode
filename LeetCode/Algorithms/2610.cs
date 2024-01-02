using System.Collections.Generic;

namespace LeetCode.Algorithms;

// MEDIUM
internal sealed class _2610
{
	public static IList<IList<int>> FindMatrix(int[] nums)
	{
		var result = new List<IList<int>>();

		var frequencies = new int[nums.Length + 1];
		for (var i = 0; i < nums.Length; i++)
		{
			var num = nums[i];
			if (frequencies[num] >= result.Count)
			{
				result.Add(new List<int>());
			}

			result[frequencies[num]].Add(num);
			frequencies[num]++;
		}

		return result;
	}
}