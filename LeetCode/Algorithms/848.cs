using System.Text;

namespace LeetCode.Algorithms
{
	class _848
	{
		public static string ShiftingLetters(string s, int[] shifts)
		{
			for (var i = shifts.Length - 2; i >= 0; i--)
			{
				shifts[i] = (shifts[i] + shifts[i + 1]) % 26;
			}

			var sb = new StringBuilder();
			for (var i = 0; i < s.Length; i++)
			{
				sb.Insert(i, (char)((s[i] - 'a' + shifts[i]) % 26 + 'a'));
			}
			return sb.ToString();
		}
	}
}
