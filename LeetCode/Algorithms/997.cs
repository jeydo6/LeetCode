namespace LeetCode.Algorithms
{
	// EASY
	internal class _997
	{
		public static int FindJudge(int n, int[][] trust)
		{
			var count = new int[n + 1];
			for (var i = 0; i < trust.Length; i++)
			{
				count[trust[i][0]]--;
				count[trust[i][1]]++;
			}
			for (var i = 1; i <= n; i++)
			{
				if (count[i] == n - 1)
				{
					return i;
				}
			}
			return -1;
		}
	}
}
