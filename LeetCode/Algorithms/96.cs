namespace LeetCode.Algorithms
{
	// MEDIUM
	internal class _96
	{
		public static int NumTrees(int n)
		{
			var graph = new int[n + 1];
			graph[0] = graph[1] = 1;

			for (var i = 2; i <= n; ++i)
			{
				for (var j = 1; j <= i; ++j)
				{
					graph[i] += graph[j - 1] * graph[i - j];
				}
			}

			return graph[n];
		}
	}
}
