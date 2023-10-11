namespace LeetCode.Algorithms;

// MEDIUM
internal class _334
{
	public static bool IncreasingTriplet(int[] nums)
	{
		var first = int.MaxValue;
		var second = int.MaxValue;
		foreach (var num in nums)
		{
			if (num <= first)
			{
				first = num;
			}
			else if (num <= second)
			{
				second = num;
			}
			else
			{
				return true;
			}
		}

		return false;
	}
}
