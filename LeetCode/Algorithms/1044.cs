using System.Collections.Generic;

namespace LeetCode.Algorithms
{
	// HARD
	internal class _1044
	{
		public static string LongestDupSubstring(string s)
		{
			var result = string.Empty;

			var left = 1;
			var right = s.Length;
			while (left <= right)
			{
				var mid = left + (right - left) / 2;

				var duplicate = GetDuplicate(mid, s);
				if (duplicate != null)
				{
					result = duplicate;
					left = mid + 1;
				}
				else
				{
					right = mid - 1;
				}
			}

			return result;
		}
		
		private static string GetDuplicate(int mid, string s)
		{
			var hash = GetHash(s[..mid]);

			var set = new HashSet<long>
			{
				hash
			};

			var pow = 1L;
			for (var i = 1; i < mid; i++)
			{
				pow *= 31;
			}

			var n = s.Length;
			for (var i = 0; i < n - mid; ++i)
			{
				hash = GetHash(pow, hash, s[i], s[i + mid]);
				if (!set.Add(hash))
				{
					return s[(i + 1)..(i + 1 + mid)];
				}
					
			}

			return null;
		}
		
		private static long GetHash(string s)
		{
			var h = 0L;
			var a = 1L;

			var n = s.Length;
			for (var k = n; k >= 1; k--) {
				var ch = s[k - 1];
				h += (ch - 'a' + 1) * a;
				a *= 31;
			}

			return h;
		}
		
		private static long GetHash(long pow, long hash, char left, char right)
		{
			return (hash - (left - 'a' + 1) * pow) * 31 + (right - 'a' + 1);
		}
	}
}