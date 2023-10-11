using System;

namespace LeetCode.Algorithms
{
	// HARD
	internal class _312
	{
		public static int MaxCoins(int[] nums)
		{
			var arr = new int[nums.Length + 2];
			var n = 1;
			for (var i = 0; i < nums.Length; i++)
			{
				if (nums[i] > 0)
				{
					arr[n++] = nums[i];
				}
			}
			arr[0] = 1;
			arr[n++] = 1;

			var memo = new int[n][];
			for (var i = 0; i < n; i++)
			{
				memo[i] = new int[n];
			}
			return Burst(memo, arr, 0, n - 1);
		}

		private static int Burst(int[][] memo, int[] nums, int left, int right)
		{
			if (left + 1 == right)
			{
				return 0;
			}

			if (memo[left][right] > 0)
			{
				return memo[left][right];
			}
			var result = 0;
			for (var i = left + 1; i < right; i++)
			{
				result = Math.Max(
					result, nums[left] * nums[i] * nums[right] +
					Burst(memo, nums, left, i) +
					Burst(memo, nums, i, right)
				);
			}
			memo[left][right] = result;
			return result;
		}
	}
}
