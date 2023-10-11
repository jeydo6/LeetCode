namespace LeetCode.Algorithms
{
	class _77
	{
		public static IList<IList<int>> Combine(int n, int k, int start = 1, IList<int> current = null)
		{
			var result = new List<IList<int>>();

			if (current == null)
			{
				current = new List<int>();
			}

			if (k == 0)
			{
				result.Add(new List<int>(current));
			}
			else
			{
				for (var i = start; i <= n - k + 1; i++)
				{
					current.Add(i);
					var temp = Combine(n, k - 1, i + 1, current);
					foreach (var combination in temp)
					{
						result.Add(combination);
					}
					current.RemoveAt(current.Count - 1);
				}
			}
			return result;
		}
	}
}
