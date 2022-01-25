namespace LeetCode.Algorithms
{
	// EASY
	internal class _941
	{
		public static bool ValidMountainArray(int[] arr)
		{
			var n = arr.Length;
			var i = 0;
			var j = n - 1;
			while (i + 1 < n && arr[i] < arr[i + 1])
			{
				i++;
			}
			while (j > 0 && arr[j - 1] > arr[j])
			{
				j--;
			}
			return i > 0 && i == j && j < n - 1;
		}
	}
}
