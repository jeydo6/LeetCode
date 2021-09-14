using System.Text;

namespace LeetCode.Algorithms
{
	class _917
	{
		public static string ReverseOnlyLetters(string s)
		{
			var sb = new StringBuilder(s);

			var i = 0;
			var j = s.Length - 1;
			while (i < j)
			{
				if (!char.IsLetter(s[i]))
				{
					i++;
				}
				else if (!char.IsLetter(s[j]))
				{
					j--;
				}
				else
				{
					sb[i] = s[j];
					sb[j] = s[i];

					i++;
					j--;
				}
			}

			return sb.ToString();
		}
	}
}
