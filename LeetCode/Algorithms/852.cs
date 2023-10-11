namespace LeetCode.Algorithms
{
	// EASY
	internal class _852
	{
		public static int PeakIndexInMountainArray(int[] arr)
		{
			var index = 0;
			while (arr[index] < arr[index + 1] && index < arr.Length - 1)
			{
				index++;
			}
			return index;
		}
	}
}
