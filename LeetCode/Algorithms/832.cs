namespace LeetCode.Algorithms
{
	// EASY
	internal class _832
	{
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
