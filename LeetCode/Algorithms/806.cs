namespace LeetCode.Algorithms
{
	// EASY
	internal class _806
	{
		public static int[] NumberOfLines(int[] widths, string str)
		{
			var result = new int[] { 1, 0 };
			foreach (var ch in str)
			{
				var width = widths[ch - 'a'];
				if (result[1] + width <= 100)
				{
					result[1] += width;
				}
				else
				{
					result[0]++;
					result[1] = width;
				}
			}
			return result;
		}
	}
}
