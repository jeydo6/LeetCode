namespace LeetCode.Algorithms
{
	class _1614
	{
		public static int MaxDepth(string s)
		{
			var max = 0;
			var depth = 0;
			foreach (var ch in s)
			{
				if (ch == '(')
				{
					depth++;
				}
				if (ch == ')')
				{
					if (depth > max)
					{
						max = depth;
					}
					depth--;
				}
			}
			return max;
		}
	}
}
