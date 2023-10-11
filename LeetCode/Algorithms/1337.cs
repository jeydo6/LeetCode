namespace LeetCode.Algorithms
{
	class _1337
	{
		public static int[] KWeakestRows(int[][] matrix, int k)
		{
			var soldiers = new int[matrix.Length];
			var positions = new int[matrix.Length];
			for (var i = 0; i < matrix.Length; i++)
			{
				positions[i] = i;
				for (var j = 0; j < matrix[0].Length; j++)
				{
					soldiers[i] += matrix[i][j];
				}
			}

			for (var i = 0; i < soldiers.Length; i++)
			{
				for (var j = 0; j < soldiers.Length - 1; j++)
				{
					if (soldiers[j] > soldiers[j + 1])
					{
						var temp = soldiers[j];
						soldiers[j] = soldiers[j + 1];
						soldiers[j + 1] = temp;

						temp = positions[j];
						positions[j] = positions[j + 1];
						positions[j + 1] = temp;
					}
				}
			}
			//for (var i = 1; i < soldiers.Length; i++)
			//{
			//	var key = soldiers[i];
			//	var p = positions[i];
			//	var j = i - 1;
			//	while (j >= 0 && soldiers[j] > key)
			//	{
			//		soldiers[j + 1] = soldiers[j];
			//		positions[j + 1] = positions[j];
			//		j--;
			//	}
			//	soldiers[j + 1] = key;
			//	positions[j + 1] = p;
			//}
			return positions[..k];
		}

		//public static int[] KWeakestRows(int[][] matrix, int k)
		//{
		//	var pairs = new int[matrix.Length][];
		//	for (var i = 0; i < matrix.Length; i++)
		//	{
		//		pairs[i] = new int[2];
		//		pairs[i][0] = i;
		//		for (var j = 0; j < matrix[0].Length; j++)
		//		{
		//			if (matrix[i][j] != 1)
		//			{
		//				break;
		//			}
		//			pairs[i][1] += matrix[i][j];
		//		}
		//	}

		//	Array.Sort(pairs, (a, b) => a[1] - b[1] != 0 ? a[1] - b[1] : a[0] - b[0]);

		//	var positions = new int[pairs.Length];
		//	for (var i = 0; i < pairs.Length; i++)
		//	{
		//		positions[i] = pairs[i][0];
		//	}
		//	return positions[..k];
		//}
	}
}
