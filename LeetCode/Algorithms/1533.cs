namespace LeetCode.Algorithms;

// MEDIUM
internal class _1533
{
	public abstract class ArrayReader
	{
		// Compares the sum of arr[l..r] with the sum of arr[x..y] 
		// return 1 if sum(arr[l..r]) > sum(arr[x..y])
		// return 0 if sum(arr[l..r]) == sum(arr[x..y])
		// return -1 if sum(arr[l..r]) < sum(arr[x..y])
		public abstract int CompareSub(int l, int r, int x, int y);

		// Returns the length of the array
		public abstract int Length();
	}

	public static int GetIndex(ArrayReader reader)
	{
		var left = 0;
		var length = reader.Length();
		while (length > 1)
		{
			length /= 2;
			var cmp = reader.CompareSub(left, left + length - 1, left + length, left + length + length - 1);
			if (cmp == 0)
			{
				return left + length + length;
			}
			if (cmp < 0)
			{
				left += length;
			}
		}
		return left;
	}
}
