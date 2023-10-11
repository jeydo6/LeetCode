namespace LeetCode.Algorithms
{
	// MEDIUM
	internal class _81
	{
		public static bool Search(int[] nums, int target)
		{
			if (nums.Length == 0)
			{
				return false;
			}

			var end = nums.Length - 1;
			var start = 0;

			while (start <= end)
			{
				var mid = (start + end) / 2;

				if (nums[mid] == target)
				{
					return true;
				}

				if (nums[start] == nums[mid])
				{
					start++;
					continue;
				}
				var pivotArray = nums[start] <= nums[mid];
				var targetArray = nums[start] <= target;
				if (pivotArray ^ targetArray)
				{
					if (pivotArray)
					{
						start = mid + 1;
					}
					else
					{
						end = mid - 1;
					}
				}
				else
				{
					if (nums[mid] < target)
					{
						start = mid + 1;
					}
					else
					{
						end = mid - 1;
					}
				}
			}
			return false;
		}
	}
}
