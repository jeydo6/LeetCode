namespace LeetCode.Algorithms
{
	// EASY
	internal class _169
	{
		public static int MajorityElement(int[] nums)
		{
			var major = nums[0];
			var count = 1;
			for (var i = 1; i < nums.Length; i++)
			{
				if (count == 0)
				{
					count++;
					major = nums[i];
				}
				else if (major == nums[i])
				{
					count++;
				}
				else count--;

			}
			return major;
		}
	}
}
