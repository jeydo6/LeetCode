namespace LeetCode.Algorithms;

// MEDIUM
internal sealed class _2149
{
	public static int[] RearrangeArray(int[] nums)
	{
		var result = new int[nums.Length];

		var posIndex = 0;
		var negIndex = 1;
		for (var i = 0; i < nums.Length; i++)
		{
			if (nums[i] > 0)
			{
				result[posIndex] = nums[i];
				posIndex += 2;
			}
			else
			{
				result[negIndex] = nums[i];
				negIndex += 2;
			}
		}

		return result;
	}
}