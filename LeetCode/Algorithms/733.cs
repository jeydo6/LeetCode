namespace LeetCode.Algorithms
{
	// EASY
	class _733
	{
		public static int[][] FloodFill(int[][] image, int sr, int sc, int newColor)
		{
			if (image[sr][sc] == newColor)
			{
				return image;
			}
			Fill(image, sr, sc, image[sr][sc], newColor);
			return image;
		}

		private static void Fill(int[][] image, int sr, int sc, int oldColor, int newColor)
		{
			if (
				sr < 0 || sr >= image.Length ||
				sc < 0 || sc >= image[0].Length ||
				image[sr][sc] != oldColor
			)
			{
				return;
			}

			image[sr][sc] = newColor;
			Fill(image, sr + 1, sc, oldColor, newColor);
			Fill(image, sr - 1, sc, oldColor, newColor);
			Fill(image, sr, sc + 1, oldColor, newColor);
			Fill(image, sr, sc - 1, oldColor, newColor);
		}
	}
}
