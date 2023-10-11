namespace LeetCode.Algorithms;

// EASY
internal class _1539
{
	public static int FindKthPositive(int[] arr, int k)
	{
		var start = 0;
		var end = arr.Length - 1;
		while (start <= end)
		{
			var mid = start + (end - start) / 2;
			if (arr[mid] - (mid + 1) < k)
			{
				start = mid + 1;
			}
			else
			{
				end = mid - 1;
			}
		}
		return start + k;
	}
}
