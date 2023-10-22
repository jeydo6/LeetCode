namespace LeetCode.Algorithms;

// HARD
internal class _1793
{
	public static int MaximumScore(int[] nums, int k)
	{
		var result = nums[k];
		var min = nums[k];
		var lo = k;
		var hi = k;
		while (lo > 0 || hi < nums.Length - 1)
		{
			if ((lo > 0 ? nums[lo - 1] : 0) < (hi < nums.Length - 1 ? nums[hi + 1] : 0))
			{
				hi++;
				if (nums[hi] < min)
				{
					min = nums[hi];
				}
			}
			else
			{
				lo--;
				if (nums[lo] < min)
				{
					min = nums[lo];
				}
			}

			var score = min * (hi - lo + 1);
			if (score > result)
			{
				result = score;
			}
		}

		return result;
	}
}
