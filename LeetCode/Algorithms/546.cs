namespace LeetCode.Algorithms
{
	class _546
	{
		public static int RemoveBoxes(int[] boxes)
		{
			var n = boxes.Length;
			var dp = new int[n][][];
			for (var i = 0; i < n; i++)
			{
				dp[i] = new int[n][];
				for (var j = 0; j < n; j++)
				{
					dp[i][j] = new int[n];
				}
			}

			for (var j = 0; j < n; j++)
			{
				for (var k = 0; k <= j; k++)
				{
					dp[j][j][k] = (k + 1) * (k + 1);
				}
			}

			for (var l = 1; l < n; l++)
			{
				for (var j = l; j < n; j++)
				{
					var i = j - l;

					for (int k = 0; k <= i; k++)
					{
						var result = (k + 1) * (k + 1) + dp[i + 1][j][0];

						for (int m = i + 1; m <= j; m++)
						{
							if (boxes[m] == boxes[i])
							{
								result = Math.Max(result, dp[i + 1][m - 1][0] + dp[m][j][k + 1]);
							}
						}

						dp[i][j][k] = result;
					}
				}
			}

			return n == 0 ? 0 : dp[0][n - 1][0];
		}
	}
}
