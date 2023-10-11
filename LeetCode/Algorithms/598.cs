namespace LeetCode.Algorithms
{
	class _598
	{
		public static int MaxCount(int m, int n, int[][] ops)
		{
			if (ops == null || ops.Length == 0)
			{
				return m * n;
			}

			var row = int.MaxValue;
			var col = int.MaxValue;
			foreach (var op in ops)
			{
				row = Math.Min(row, op[0]);
				col = Math.Min(col, op[1]);
			}
			return row * col;
		}
	}
}
