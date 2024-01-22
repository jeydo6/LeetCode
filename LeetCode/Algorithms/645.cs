namespace LeetCode.Algorithms;

// EASY
internal sealed class _645
{
	public static int[] FindErrorNums(int[] nums)
	{
		var array = new int[nums.Length + 1];
		for (var i = 0; i < nums.Length; i++)
		{
			array[nums[i]]++;
		}

		var duplicate = -1;
		var missing = 1;
		for (var i = 1; i < array.Length; i++)
		{
			if (array[i] == 0)
			{
				missing = i;
			}
			else if (array[i] == 2)
			{
				duplicate = i;
			}
		}

		return new int[] { duplicate, missing };
	}
}
