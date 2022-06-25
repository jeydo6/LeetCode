namespace LeetCode.Algorithms
{
	// MEDIUM
	internal class _665
	{
		public static bool CheckPossibility(int[] nums)
		{
			var numViolations = 0;
			for (var i = 1; i < nums.Length; i++)
			{

				if (nums[i - 1] > nums[i])
				{

					if (numViolations == 1)
					{
						return false;
					}

					numViolations++;

					if (i < 2 || nums[i - 2] <= nums[i])
					{
						nums[i - 1] = nums[i];
					}
					else
					{
						nums[i] = nums[i - 1];
					}
				}
			}

			return true;
		}
	}
}
