using System.Text;

namespace LeetCode.Algorithms
{
	class _1370
	{
		public static string SortString(string s)
		{
			var dict = new int[26];
			for (var i = 0; i < s.Length; i++)
			{
				dict[s[i] - 'a']++;
			}

			var sb = new StringBuilder(s.Length);
			int count = 0;
			while (count < s.Length)
			{
				for (var i = 0; i < 26; i++)
				{
					if (dict[i] > 0)
					{
						sb.Append((char)(i + 'a'));
						dict[i] = dict[i] - 1;
						count++;
					}
				}
				for (var i = 25; i >= 0; i--)
				{
					if (dict[i] > 0)
					{
						sb.Append((char)(i + 'a'));
						dict[i] = dict[i] - 1;
						count++;
					}
				}
			}
			return sb.ToString();
		}
	}
}
