using System;
using System.Collections.Generic;

namespace LeetCode.Algorithms
{
	internal class _15
	{
		public static IList<IList<int>> ThreeSum(int[] nums)
		{
			var result = new List<IList<int>>();
			
			Array.Sort(nums);

			for (var i = 0; i < nums.Length; i++)
			{
				var target = -nums[i];
				var lo = i + 1;
				var hi = nums.Length - 1;

				while (lo < hi)
				{
					var sum = nums[lo] + nums[hi];
					
					if (sum < target)
					{
						lo++;
					}
					else if (sum > target)
					{
						hi--;
					}
					else
					{
						var triplet = new List<int> {nums[i], nums[lo], nums[hi]};
						result.Add(triplet);

						while (lo < hi && nums[lo] == triplet[1])
						{
							lo++;
						}

						while (lo < hi && nums[hi] == triplet[2])
						{
							hi--;
						}
					}
				}

				while (i + 1 < nums.Length && nums[i + 1] == nums[i])
				{
					i++;
				}
			}

			return result;
		}
	}
}