namespace Leetcode.Algorithms
{
	// EASY
	internal class _944
	{
		public static int MinDeletionSize(string[] arr)
		{
			if (arr.Length < 2)
			{
				return 0;
			}

			var result = 0;
			for (var j = 0; j < arr[0].Length; j++)
			{
				for (var i = 1; i < arr.Length; i++)
				{
					if (arr[i - 1][j] > arr[i][j])
					{
						result++;
						break;
					}
				}
			}
			return result;
		}
	}
}
