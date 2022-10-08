using System;

namespace LeetCode.Algorithms;

// MEDIUM
internal class _16
{
	public static int ThreeSumClosest(int[] nums, int target)
	{
		var result = int.MaxValue;

		Array.Sort(nums);

		var min = int.MaxValue;
		for (var i = 0; i < nums.Length - 2; i++)
		{
			var left = i + 1;
			var right = nums.Length - 1;

			while (left < right)
			{
				var sum = nums[i] + nums[left] + nums[right];

				if (sum == target)
				{
					min = 0;
					result = target;
					break;
				}
				else
				{
					var d = Math.Abs(sum - target);
					if (d < min)
					{
						min = d;
						result = sum;
					}

					if (sum < target)
					{
						left++;
					}
					else
					{
						right--;
					}
				}
			}
		}

		return result;
	}
}
