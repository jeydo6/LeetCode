namespace LeetCode.Algorithms
{
	public class _832
	{
		//public Int32[][] FlipAndInvertImage(Int32[][] A)
		//{
		//    foreach (Int32[] row in A)
		//    {
		//        Array.Reverse(row);
		//    }

		//    foreach (Int32[] row in A)
		//    {
		//        for (Int32 i = 0; i < row.Length; i++)
		//        {
		//            row[i] = (row[i] + 1) % 2;
		//        }
		//    }
		//    return A;
		//}

		public static int[][] FlipAndInvertImage(int[][] image)
		{
			var length = image.Length;
			for (var i = 0; i < length; i++)
			{
				for (var j = 0; j < length / 2; j++)
				{
					var temp = image[i][j];
					image[i][j] = (image[i][^(j + 1)] + 1) % 2;
					image[i][^(j + 1)] = (temp + 1) % 2;
				}

				if (length % 2 == 1)
				{
					image[i][length / 2] = (image[i][length / 2] + 1) % 2;
				}
			}

			return image;
		}
	}
}
