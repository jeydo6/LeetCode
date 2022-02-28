using System.Collections.Generic;

namespace LeetCode.Algorithms
{
	// EASY
	internal class _228
	{
		public static IList<string> SummaryRanges(int[] nums)
		{
			var list = new List<string>();
			if (nums.Length == 1)
			{
				list.Add(nums[0] + "");
				return list;
			}

			for (var i = 0; i < nums.Length; i++)
			{
				int a = nums[i];
				while (i + 1 < nums.Length && (nums[i + 1] - nums[i]) == 1)
				{
					i++;
				}
				if (a != nums[i])
				{
					list.Add(a + "->" + nums[i]);
				}
				else
				{
					list.Add(a + "");
				}
			}
			return list;
		}
	}
}
