namespace LeetCode.Algorithms;

// HARD
internal sealed class _629
{
	private const int Modulo = 1000000007;

	public static int KInversePairs(int n, int k)
	{
		var dp = new int[k + 1];
		for (var i = 1; i <= n; i++)
		{
			var temp = new int[k + 1];
			temp[0] = 1;
			for (var j = 1; j <= k; j++)
			{
				var val = (dp[j] + Modulo - ((j - i) >= 0 ? dp[j - i] : 0)) % Modulo;
				temp[j] = (temp[j - 1] + val) % Modulo;
			}
			dp = temp;
		}

		return (dp[k] + Modulo - (k > 0 ? dp[k - 1] : 0)) % Modulo;
	}
}