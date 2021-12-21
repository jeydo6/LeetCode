namespace Leetcode.Algorithms
{
	// EASY
	internal class _985
	{
		public static int[] SumEvenAfterQueries(int[] arr, int[][] queries)
		{
			var result = new int[queries.Length];

			var sum = 0;
			foreach (var a in arr)
			{
				if (a % 2 == 0)
				{
					sum += a;
				}
			}

			for (var i = 0; i < queries.Length; i++)
			{
				var index = queries[i][1];
				var val = queries[i][0];

				if (arr[index] % 2 == 0)
				{
					sum -= arr[index];
				}

				arr[index] += val;

				if (arr[index] % 2 == 0)
				{
					sum += arr[index];
				}

				result[i] = sum;
			}
			return result;
		}
	}
}
