using System.Text;

namespace Leetcode.Algorithms
{
	public class _557
	{
		//public String ReverseWords(String s)
		//{
		//	StringBuilder result = new StringBuilder(s.Length + 1);
		//	StringBuilder w = new StringBuilder();

		//	foreach (Char c in s)
		//	{
		//		if (c != ' ')
		//		{
		//			w.Insert(0, c);
		//		}
		//		else
		//		{
		//			result.Append(w);
		//			result.Append(" ");

		//			w.Clear();
		//		}
		//	}

		//	if (w.Length > 0)
		//	{
		//		result.Append(w);
		//		result.Append(" ");
		//	}

		//	return result
		//		.ToString()
		//		.TrimEnd();
		//}

		public static string ReverseWords(string s)
		{
			var result = new StringBuilder(s.Length);
			var words = s.Split(' ');
			for (var i = 0; i < words.Length; i++)
			{
				for (var j = 0; j < words[i].Length; j++)
				{
					result.Append(words[i][^(j + 1)]);
				}
				result.Append(' ');
			}
			return result
				.ToString()
				.TrimEnd();
		}
	}
}
