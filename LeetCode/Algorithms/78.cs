using System.Collections.Generic;

namespace LeetCode.Algorithms
{
	// EASY
	internal class _78
	{
		public static IList<IList<int>> Subsets(int[] nums)
		{
			var result = new List<IList<int>>
			{
				new List<int>()
			};
			for (var i = 0; i < nums.Length; i++)
			{
				var count = result.Count;
				for (var j = 0; j < count; j++)
				{
					var subset = new List<int>(result[j])
					{
						nums[i]
					};
					result.Add(subset);
				}
			}
			return result;
		}
	}
}
