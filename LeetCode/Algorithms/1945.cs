using System.Linq;

namespace LeetCode.Algorithms
{
	class _1945
	{
		public static int GetLucky(string s, int k)
		{
			s = string.Concat(
				s.Select(ch => ch - 'a' + 1)
			);

			for (var i = 0; i < k; i++)
			{
				s = string.Concat(
					s.Select(ch => ch - '0').Sum()
				);
			}

			return int.Parse(s);
		}
	}
}
