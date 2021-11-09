using System.Collections.Generic;

namespace LeetCode.Algorithms
{
	// HARD
	internal class _1178
	{
		public static IList<int> FindNumOfValidWords(string[] words, string[] puzzles)
		{
			var dict = new Dictionary<int, int>();
			foreach (var w in words)
			{
				var mask = 0;
				for (var i = 0; i < w.Length; i++)
				{
					mask |= 1 << (w[i] - 'a');
				}

				if (!dict.ContainsKey(mask))
				{
					dict[mask] = 0;
				}
				dict[mask]++;
			}

			var result = new List<int>();
			foreach (var p in puzzles)
			{
				var mask = 0;
				for (var i = 0; i < p.Length; i++)
				{
					mask |= 1 << (p[i] - 'a');
				}

				var r = 0;
				var sub = mask;
				var first = 1 << (p[0] - 'a');
				while (true)
				{
					if ((sub & first) == first && dict.ContainsKey(sub))
					{
						r += dict[sub];
					}

					if (sub == 0)
					{
						break;
					}

					sub = (sub - 1) & mask;
				}
				result.Add(r);
			}
			return result;
		}
	}
}
