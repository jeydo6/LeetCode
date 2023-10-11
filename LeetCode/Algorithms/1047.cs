using System.Text;

namespace LeetCode.Algorithms
{
	internal class _1047
	{
		public static string RemoveDuplicates(string s)
		{
			var sb = new StringBuilder();
			for (var i = 0; i < s.Length; i++)
			{
				if (sb.Length != 0 && s[i] == sb[^1])
				{
					sb.Remove(sb.Length - 1, 1);
				}
				else
				{
					sb.Append(s[i]);
				}
			}
			return sb.ToString();
		}
	}
}
