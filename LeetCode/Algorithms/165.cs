using System;

namespace LeetCode.Algorithms
{
	// MEDIUM
	internal class _165
	{
		public static int CompareVersion(string version1, string version2)
		{
			var levels1 = version1.Split(".");
			var levels2 = version2.Split(".");

			var length = Math.Max(levels1.Length, levels2.Length);
			for (var i = 0; i < length; i++)
			{
				var v1 = i < levels1.Length ? int.Parse(levels1[i]) : 0;
				var v2 = i < levels2.Length ? int.Parse(levels2[i]) : 0;
				var compare = v1.CompareTo(v2);
				if (compare != 0)
				{
					return compare;
				}
			}
			return 0;
		}
	}
}
