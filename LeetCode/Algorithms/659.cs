using System;

namespace LeetCode.Algorithms
{
	// MEDIUM
	internal class _659
	{
		public static bool IsPossible(int[] nums)
		{
			var start = 0;
			var end = nums.Length - 1;

			for (var i = 1; i <= end; i++)
			{
				if (nums[i] - nums[i - 1] > 1)
				{
					if (!IsSegmentValid(nums, start, i - 1))
					{
						return false;
					}

					start = i;
				}
			}

			return IsSegmentValid(nums, start, nums.Length - 1);
		}

		private static bool IsSegmentValid(int[] nums, int start, int end)
		{
			var lengthOneSubsequences = 0;
			var lengthTwoSubsequences = 0;
			var totalNoOfSubsequences = 0;

			var frequency = 0;
			for (var i = start; i <= end; i++)
			{
				if (i > start && nums[i] == nums[i - 1])
				{
					frequency++;
				}
				else if (frequency < lengthOneSubsequences + lengthTwoSubsequences)
				{
					return false;
				}
				else
				{
					lengthTwoSubsequences = lengthOneSubsequences;
					lengthOneSubsequences = Math.Max(0, frequency - totalNoOfSubsequences);
					totalNoOfSubsequences = frequency;
					frequency = 1;
				}
			}

			lengthTwoSubsequences = lengthOneSubsequences;
			lengthOneSubsequences = Math.Max(0, frequency - totalNoOfSubsequences);

			return lengthOneSubsequences == 0 && lengthTwoSubsequences == 0;
		}
	}
}
