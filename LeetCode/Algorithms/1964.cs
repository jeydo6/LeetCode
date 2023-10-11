namespace LeetCode.Algorithms;

// HARD
internal class _1964
{
	public static int[] LongestObstacleCourseAtEachPosition(int[] obstacles)
	{
		var result = new int[obstacles.Length];
		var lis = new int[obstacles.Length];
		var lisLength = 0;
		for (var i = 0; i < obstacles.Length; i++)
		{
			var height = obstacles[i];
			var index = BisectRight(lis, height, lisLength);
			if (index == lisLength)
			{
				lisLength++;
			}

			lis[index] = height;
			result[i] = index + 1;
		}
		return result;
	}

	private static int BisectRight(int[] arr, int target, int right)
	{
		if (right == 0)
		{
			return 0;
		}

		var left = 0;
		while (left < right)
		{
			var mid = left + (right - left) / 2;
			if (arr[mid] <= target)
			{
				left = mid + 1;
			}
			else
			{
				right = mid;
			}
		}
		return left;
	}
}
