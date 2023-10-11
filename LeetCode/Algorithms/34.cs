namespace LeetCode.Algorithms
{
	// MEDIUM
	internal class _34
	{
		public static int[] SearchRange(int[] nums, int target)
		{
			var firstOccurrence = FindBound(nums, target, true);

			if (firstOccurrence == -1)
			{
				return new int[] { -1, -1 };
			}

			var lastOccurrence = FindBound(nums, target, false);

			return new int[] { firstOccurrence, lastOccurrence };
		}

		private static int FindBound(int[] nums, int target, bool isFirst)
		{
			var lo = 0;
			var hi = nums.Length - 1;
			while (lo <= hi)
			{
				var mid = (lo + hi) / 2;
				if (nums[mid] == target)
				{
					if (isFirst)
					{
						if (mid == lo || nums[mid - 1] != target)
						{
							return mid;
						}
						hi = mid - 1;
					}
					else
					{
						if (mid == hi || nums[mid + 1] != target)
						{
							return mid;
						}
						lo = mid + 1;
					}

				}
				else if (nums[mid] > target)
				{
					hi = mid - 1;
				}
				else
				{
					lo = mid + 1;
				}
			}

			return -1;
		}
	}
}
