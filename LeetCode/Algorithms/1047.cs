using System.Text;

namespace Leetcode.Algorithms
{
	internal class _1047
	{
		public static string RemoveDuplicates(string str)
		{
			while (str.Length > 1)
			{
				var sb = new StringBuilder(str);

				var i = 0;
				var j = 0;

				while (i < str.Length - 1)
				{
					if (str[i] == str[i + 1])
					{
						sb.Remove(j, 2);

						i += 2;
					}
					else
					{
						i++;
						j++;
					}
				}

				if (sb.Length != str.Length)
				{
					str = sb.ToString();
				}
				else
				{
					break;
				}
			}
			return str;
		}
	}
}
