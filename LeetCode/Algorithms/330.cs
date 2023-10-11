namespace LeetCode.Algorithms
{
	class _330
	{
		public static int MinPatches(int[] nums, int n)
		{
			var miss = 1L;
			var added = 0;
			var i = 0;
			while (miss <= n)
			{
				if (i < nums.Length && nums[i] <= miss)
				{
					miss += nums[i++];
				}
				else
				{
					miss += miss;
					added++;
				}
			}
			return added;
		}
	}
}
