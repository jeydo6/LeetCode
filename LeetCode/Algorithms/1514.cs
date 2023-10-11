namespace LeetCode.Algorithms;

// MEDIUM
internal class _1514
{
	public static double MaxProbability(int n, int[][] edges, double[] succProb, int start, int end)
	{
		var result = new double[n];
		result[start] = 1.0;

		for (var i = 0; i < n - 1; i++)
		{
			var updated = false;
			for (var j = 0; j < edges.Length; j++)
			{
				var u = edges[j][0];
				var v = edges[j][1];
				var pathProb = succProb[j];
				if (result[u] * pathProb > result[v])
				{
					result[v] = result[u] * pathProb;
					updated = true;
				}

				if (result[v] * pathProb > result[u])
				{
					result[u] = result[v] * pathProb;
					updated = true;
				}
			}

			if (!updated)
			{
				break;
			}
		}

		return result[end];
	}
}