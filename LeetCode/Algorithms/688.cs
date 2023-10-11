namespace LeetCode.Algorithms;

// MEDIUM
internal class _688
{
	private static readonly int[][] _directions =
	{
		new int[] { 1, 2 }, new int[] { 1, -2 }, new int[] { -1, 2 }, new int[] { -1, -2 }, new int[] { 2, 1 },
		new int[] { 2, -1 }, new int[] { -2, 1 }, new int[] { -2, -1 }
	};

	public static double KnightProbability(int n, int k, int row, int column)
	{
		var prevDp = new double[n][];
		var currentDp = new double[n][];
		for (var i = 0; i < n; i++)
		{
			prevDp[i] = new double[n];
			currentDp[i] = new double[n];
		}

		prevDp[row][column] = 1;

		// Iterate over the number of moves
		for (var moves = 1; moves <= k; moves++)
		{
			for (var i = 0; i < n; i++)
			{
				for (var j = 0; j < n; j++)
				{
					currentDp[i][j] = 0;

					foreach (var direction in _directions)
					{
						var prevI = i - direction[0];
						var prevJ = j - direction[1];

						if (prevI >= 0 && prevI < n && prevJ >= 0 && prevJ < n)
						{
							currentDp[i][j] += prevDp[prevI][prevJ] / 8;
						}
					}
				}
			}

			(prevDp, currentDp) = (currentDp, prevDp);
		}

		var result = 0.0;
		for (var i = 0; i < n; i++)
		{
			for (var j = 0; j < n; j++)
			{
				result += prevDp[i][j];
			}
		}

		return result;
	}
}