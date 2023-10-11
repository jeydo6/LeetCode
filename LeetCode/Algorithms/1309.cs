using System.Text;

namespace LeetCode.Algorithms
{
	class _1309
	{
		//public static string FreqAlphabets(string s)
		//{
		//	var result = new string('\0', s.Length).ToCharArray();
		//	var index = 0;
		//	for (var i = 0; i < s.Length; i++)
		//	{
		//		var ch = char.MinValue;
		//		if (s[^(i + 1)] == '#')
		//		{
		//			ch = (char)((s[^(i + 3)] - '0') * 10 + (s[^(i + 2)] - '0') + 'a' - 1);
		//			i += 2;
		//		}
		//		else
		//		{
		//			ch = (char)(s[^(i + 1)] - '0' + 'a' - 1);
		//		}
		//		result[^(index + 1)] = ch;
		//		index++;
		//	}
		//	return new string(result[^index..]);
		//}

		public static string FreqAlphabets(string s)
		{
			var sb = new StringBuilder(s.Length);
			for (var i = 0; i < s.Length; i++)
			{
				var ch = char.MinValue;
				if (s[^(i + 1)] == '#')
				{
					ch = (char)((s[^(i + 3)] - '0') * 10 + (s[^(i + 2)] - '0') + 'a' - 1);
					i += 2;
				}
				else
				{
					ch = (char)(s[^(i + 1)] - '0' + 'a' - 1);
				}
				sb.Insert(0, ch);
			}
			return sb.ToString();
		}
	}
}
