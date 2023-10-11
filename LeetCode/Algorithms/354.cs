using System;

namespace LeetCode.Algorithms
{
	// HARD
	internal class _354
	{
		public static int MaxEnvelopes(int[][] envelopes)
		{
			Array.Sort(envelopes, (arr1, arr2) =>
			{
				if (arr1[0] == arr2[0])
				{
					return arr2[1] - arr1[1];
				}
				else
				{
					return arr1[0] - arr2[0];
				}
			});

			var nums = new int[envelopes.Length];
			for (var i = 0; i < envelopes.Length; i++)
			{
				nums[i] = envelopes[i][1];
			}
			return GetLength(nums);
		}

		private static int GetLength(int[] nums)
		{
			var dp = new int[nums.Length];
			var length = 0;
			for (var i = 0; i < nums.Length; i++)
			{
				var j = Array.BinarySearch(dp, 0, length, nums[i]);
				if (j < 0)
				{
					j = -(j + 1);
				}
				dp[j] = nums[i];
				if (j == length)
				{
					length++;
				}
			}
			return length;
		}
	}
}
