namespace LeetCode.Algorithms
{
	class _1252
	{
		//public static int OddCells(int m, int n, int[][] indices)
		//{
		//	var matrix = new int[m][];
		//	for (var i = 0; i < m; i++)
		//	{
		//		matrix[i] = new int[n];
		//	}

		//	foreach (var pair in indices)
		//	{
		//		for (var j = 0; j < n; j++)
		//		{
		//			matrix[pair[0]][j]++;
		//		}
		//		for (var i = 0; i < m; i++)
		//		{
		//			matrix[i][pair[1]]++;
		//		}
		//	}

		//	var result = 0;
		//	for (var i = 0; i < m; i++)
		//	{
		//		for (var j = 0; j < n; j++)
		//		{
		//			if (matrix[i][j] % 2 == 1)
		//			{
		//				result++;
		//			}
		//		}
		//	}
		//	return result;
		//}

		public static int OddCells(int m, int n, int[][] indices)
		{
			var rows = new int[m];
			var cols = new int[n];
			foreach (var index in indices)
			{
				rows[index[0]]++;
				cols[index[1]]++;
			}

			var result = 0;
			for (var i = 0; i < m; i++)
			{
				for (var j = 0; j < n; j++)
				{
					if ((rows[i] + cols[j]) % 2 == 1)
					{
						result++;
					}
				}
			}
			return result;
		}
	}
}
