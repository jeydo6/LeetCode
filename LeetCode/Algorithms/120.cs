namespace LeetCode.Algorithms
{
	// MEDIUM
	class _120
	{
		public static int MinimumTotal(IList<IList<int>> triangle)
		{
			if (triangle.Count == 0)
			{
				return 0;
			}

			var list = new List<int>(triangle[^1]);
			for (var layer = triangle.Count - 2; layer >= 0; layer--)
			{
				for (var i = 0; i <= layer; i++)
				{
					list[i] = Math.Min(list[i], list[i + 1]) + triangle[layer][i];
				}
			}
			return list[0];
		}
	}
}
