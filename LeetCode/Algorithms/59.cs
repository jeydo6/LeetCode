namespace LeetCode.Algorithms;

// MEDIUM
internal class _59
{
	public static int[][] GenerateMatrix(int n)
	{
		var result = new int[n][];
		for (var i = 0; i < n; i++)
		{
			result[i] = new int[n];
		}

		var count = 1;
		for (var layer = 0; layer < (n + 1) / 2; layer++)
		{
			for (var ptr = layer; ptr < n - layer; ptr++)
			{
				result[layer][ptr] = count++;
			}
			for (var ptr = layer + 1; ptr < n - layer; ptr++)
			{
				result[ptr][n - layer - 1] = count++;
			}
			for (var ptr = layer + 1; ptr < n - layer; ptr++)
			{
				result[n - layer - 1][n - ptr - 1] = count++;
			}
			for (var ptr = layer + 1; ptr < n - layer - 1; ptr++)
			{
				result[n - ptr - 1][layer] = count++;
			}
		}
		return result;
	}
}
