namespace LeetCode.Algorithms
{
	// MEDIUM
	internal class _1306
	{
		public static bool CanReach(int[] arr, int start)
		{
			return
				start >= 0 &&
				start < arr.Length &&
				arr[start] >= 0 &&
				(
					(arr[start] = -arr[start]) == 0 ||
					CanReach(arr, start + arr[start]) ||
					CanReach(arr, start - arr[start])
				);
		}
	}
}
