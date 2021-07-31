namespace LeetCode.Algorithms
{
	class _1221
	{
		public static int BalancedStringSplit(string s)
		{
			var result = 0;

			var depth = 0;
			foreach (var ch in s)
			{
				depth += ch switch
				{
					'L' => 1,
					'R' => -1,
					_ => 0
				};

				if (depth == 0)
				{
					result++;
				}
			}

			return result;
		}
	}
}
