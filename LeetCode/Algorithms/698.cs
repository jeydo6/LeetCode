namespace LeetCode.Algorithms
{
	internal class _698
	{
		// MEDIUM
		public bool CanPartitionKSubsets(int[] nums, int k, int[] visited = null, int startIndex = 0, int currentSum = 0, int currentNumber = 0, int target = 0)
		{
			if (target == 0)
			{
				var sum = 0;
				for (var i = 0; i < nums.Length; i++)
				{
					sum += nums[i];
				}
				if (k <= 0 || sum % k != 0)
				{
					return false;
				}
				target = sum / k;
			}
			if (visited == null)
			{
				visited = new int[nums.Length];
			}

			if (k == 1)
			{
				return true;
			}
			if (currentSum == target && currentNumber > 0)
			{
				return CanPartitionKSubsets(nums, k - 1, visited, 0, 0, 0, target);
			}
			for (var i = startIndex; i < nums.Length; i++)
			{
				if (visited[i] == 0)
				{
					visited[i] = 1;
					if (CanPartitionKSubsets(nums, k, visited, i + 1, currentSum + nums[i], currentNumber++, target))
					{
						return true;
					}
					visited[i] = 0;
				}
			}
			return false;
		}
	}
}
