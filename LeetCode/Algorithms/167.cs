namespace LeetCode.Algorithms
{
	// MEDIUM
	internal class _167
	{
		public static int[] TwoSum(int[] numbers, int target)
		{
			var lo = 0;
			var hi = numbers.Length - 1;
			while (lo < hi)
			{
				var sum = numbers[lo] + numbers[hi];
				if (sum < target)
				{
					lo++;
				}
				else if (sum > target)
				{
					hi--;
				}
				else
				{
					return new int[2] { lo + 1, hi + 1 };
				}
			}
			return new int[] { -1, -1 };
		}
	}
}
