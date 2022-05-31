using System.Collections.Generic;

namespace LeetCode.Algorithms
{
	// MEIUM
	internal class _1461
	{
		public static bool HasAllCodes(string s, int k)
		{
			var need = 1 << k;
			var set = new HashSet<string>();
			for (var i = k; i <= s.Length; i++)
			{
				var substring = s[(i - k)..i];
				if (!set.Contains(substring))
				{
					set.Add(substring);
					need--;

					if (need == 0)
					{
						return true;
					}
				}
			}
			return false;
		}
	}
}
